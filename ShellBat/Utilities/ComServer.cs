namespace ShellBat.Utilities;

public sealed partial class ComServer : IDisposable
{
    private ConcurrentBag<uint> _cookies = [];
    private readonly ConcurrentDictionary<Type, ComClassFactory> _factories = [];

    public HRESULT RegisterClassObject<T>(Func<T> createInstance, REGCLS options = REGCLS.REGCLS_MULTIPLEUSE, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(createInstance);
        if (!_factories.TryGetValue(typeof(T), out var factory))
        {
            var instance = createInstance() ?? throw new InvalidOperationException();
            factory = new ComClassFactory(instance);
            _factories[typeof(T)] = factory;
        }

        uint cookie = 0;
        var hr = ComObject.WithComInstance(factory, unk =>
        {
            return DirectN.Functions.CoRegisterClassObject(typeof(T).GUID, unk, CLSCTX.CLSCTX_LOCAL_SERVER, (uint)options, out cookie).ThrowOnError(throwOnError);
        }, createIfNeeded: true);
        if (hr.IsError)
            return hr;

        _cookies.Add(cookie);
        return hr;
    }

    public void Dispose()
    {
        var cookies = Interlocked.Exchange(ref _cookies, []);
        foreach (var cookie in cookies)
        {
            _ = DirectN.Functions.CoRevokeClassObject(cookie);
        }
    }

    public static void Register<T>(RegistryKey rootKey, string? progId = null, string? exePath = null) => Register(rootKey, typeof(T).GUID, progId, exePath);
    public static void Register(RegistryKey rootKey, Guid clsid, string? progId = null, string? exePath = null)
    {
        ArgumentNullException.ThrowIfNull(rootKey);
        if (!string.IsNullOrEmpty(progId))
        {
            using var progidKey = rootKey.CreateSubKey($@"Software\Classes\{progId}\CLSID");
            progidKey.SetValue(null, clsid.ToString("B"));
        }

        using var serverKey = rootKey.CreateSubKey($@"Software\Classes\CLSID\{clsid:B}\LocalServer32");
        exePath ??= Environment.ProcessPath ?? throw new ArgumentNullException(nameof(exePath));
        serverKey.SetValue(null, exePath);
    }

    public static bool IsRegistered<T>(RegistryKey rootKey) => IsRegistered(rootKey, typeof(T).GUID);
    public static bool IsRegistered(RegistryKey rootKey, Guid clsid)
    {
        using var key = rootKey.OpenSubKey($@"Software\Classes\CLSID\{clsid:B}", false);
        return key != null;
    }

    public static void Unregister<T>(RegistryKey rootKey, string? progId = null) => Unregister(rootKey, typeof(T).GUID, progId);
    public static void Unregister(RegistryKey rootKey, Guid clsid, string? progId = null)
    {
        ArgumentNullException.ThrowIfNull(rootKey);
        rootKey.DeleteSubKeyTree($"Software\\Classes\\CLSID\\{clsid:B}", false);
        if (!string.IsNullOrEmpty(progId))
        {
            rootKey.DeleteSubKeyTree($"Software\\Classes\\{progId}", false);
        }
    }

    public static void Resume(bool throwOnError = true) => DirectN.Functions.CoResumeClassObjects().ThrowOnError(throwOnError);
    public static void Suspend(bool throwOnError = true) => DirectN.Functions.CoSuspendClassObjects().ThrowOnError(throwOnError);

    [System.Runtime.InteropServices.Marshalling.GeneratedComClass]
    private sealed partial class ComClassFactory(object instance) : IClassFactory
    {
        public HRESULT LockServer(BOOL fLock) => DirectN.Constants.S_OK;
        public HRESULT CreateInstance(nint pUnkOuter, in Guid riid, out nint ppvObject)
        {
            if (pUnkOuter != 0)
            {
                ppvObject = 0;
                return DirectN.Constants.CLASS_E_NOAGGREGATION;
            }

            nint ppv = 0;
            ComObject.WithComInstance(instance, unk => ppv = unk, createIfNeeded: true);
            ppvObject = ppv;
            return ppvObject != 0 ? DirectN.Constants.S_OK : DirectN.Constants.E_NOINTERFACE;
        }
    }
}
