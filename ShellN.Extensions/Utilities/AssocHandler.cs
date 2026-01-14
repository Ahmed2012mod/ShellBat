namespace ShellN.Extensions.Utilities;

public sealed class AssocHandler(IComObject<IAssocHandler> inner) : InterlockedComObject<IAssocHandler>(inner)
{
    public bool IsRecommended => NativeObject.IsRecommended().IsOk;
    public string Key { get; internal set; } = null!; // used to identify the handler

    public string? Name
    {
        get
        {
            NativeObject.GetName(out var p);
            var str = p.ToString();
            if (p.Value != 0)
            {
                Marshal.FreeCoTaskMem(p.Value);
            }
            return str;
        }
    }

    public string? UIName
    {
        get
        {
            NativeObject.GetUIName(out var p);
            var str = p.ToString();
            if (p.Value != 0)
            {
                Marshal.FreeCoTaskMem(p.Value);
            }
            return str;
        }
    }

    public string? ProgId
    {
        get
        {
            var owp = ComObject.As<IObjectWithProgID>();
            if (owp == null)
                return null;

            owp.Object.GetProgID(out var p);
            var str = p.ToString();
            if (p.Value != 0)
            {
                Marshal.FreeCoTaskMem(p.Value);
            }
            return str;
        }
    }

    public string? AppUserModelId
    {
        get
        {
            var owp = ComObject.As<IObjectWithAppUserModelID>();
            if (owp == null)
                return null;

            owp.Object.GetAppID(out var p);
            var str = p.ToString();
            if (p.Value != 0)
            {
                Marshal.FreeCoTaskMem(p.Value);
            }
            return str;
        }
    }

    public IconLocation? IconLocation
    {
        get
        {
            NativeObject.GetIconLocation(out var path, out var index);
            if (path.Value == 0)
                return null;

            var iconPath = path.ToString();
            if (iconPath == null)
                return null;

            Marshal.FreeCoTaskMem(path.Value);
            return new IconLocation(iconPath, index);
        }
    }

    public override string ToString() => UIName ?? Name ?? ProgId ?? AppUserModelId ?? "???";

    public HRESULT MakeDefault(string description, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(description);
        return NativeObject.MakeDefault(PWSTR.From(description)).ThrowOnError(throwOnError);
    }

    public HRESULT Invoke(IDataObject dataObject, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(dataObject);
        return NativeObject.Invoke(dataObject).ThrowOnError(throwOnError);
    }

    public IComObject<IAssocHandlerInvoker>? CreateInvoker(IDataObject dataObject, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(dataObject);
        NativeObject.CreateInvoker(dataObject, out var obj).ThrowOnError(throwOnError);
        return new ComObject<IAssocHandlerInvoker>(obj);
    }

    public static IReadOnlyList<AssocHandler> Enumerate(string extra, ASSOC_FILTER filter, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(extra);
        Functions.SHAssocEnumHandlers(PWSTR.From(extra), filter, out var obj).ThrowOnError(throwOnError);
        using var enumHandlers = new ComObject<IEnumAssocHandlers>(obj);
        return Enumerate(enumHandlers).AsReadOnly();
    }

    public static IReadOnlyList<AssocHandler> EnumerateForProtocolByApplication(string protocol, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(protocol);
        Functions.SHAssocEnumHandlersForProtocolByApplication(PWSTR.From(protocol), typeof(IEnumAssocHandlers).GUID, out var unk).ThrowOnError(throwOnError);
        if (unk == 0)
            return [];

        using var enumHandlers = DirectN.Extensions.Com.ComObject.FromPointer<IEnumAssocHandlers>(unk);
        return Enumerate(enumHandlers).AsReadOnly();
    }

    private static List<AssocHandler> Enumerate(IComObject<IEnumAssocHandlers>? enumHandlers)
    {
        if (enumHandlers == null)
            return [];

        var list = new List<AssocHandler>();
        var unks = new nint[1];
        do
        {
            if (enumHandlers.Object.Next(1, unks, 0) != 0)
                break;

            var handler = DirectN.Extensions.Com.ComObject.FromPointer<IAssocHandler>(unks[0]);
            if (handler != null)
            {
                var ah = new AssocHandler(handler);
                var key = ah.ProgId ?? ah.AppUserModelId ?? ah.Name ?? ah.UIName;
                if (string.IsNullOrWhiteSpace(key))
                {
                    ah.Dispose();
                    continue;
                }

                ah.Key = key.ComputeGuidHash().ToString("N");
                list.Add(ah);
            }
        }
        while (true);
        return list;
    }
}
