namespace ShellN.Extensions;

public sealed class ShellView : InterlockedComObject<IShellView>
{
    private static readonly Lazy<ShellView?> _desktop = new(GetDesktop);
    public static ShellView? Desktop => _desktop.Value;

    public static ShellView? FromObject(object? obj, bool owned = true)
    {
        if (obj == null)
            return null;

        if (obj is nint unk)
        {
            var si = DirectN.Extensions.Com.ComObject.FromPointer<IShellView>(unk);
            if (si != null)
                return FromObject(si.Object, owned);

            return null;
        }

        if (obj is ShellView view)
            return view;

        if (obj is IShellView shellView)
            return new ShellView(null, shellView, owned);

        return null;
    }

    public static IEnumerable<ShellView> Windows
    {
        get
        {
            CheckSTAThread();
            using var windows = DirectN.Extensions.Com.ComObject.CoCreate<IShellWindows>(Constants.ShellWindows);
            if (windows == null)
                yield break;

            windows.Object.get_Count(out var count);
            for (var i = 0; i < count; i++)
            {
                using var idx = new Variant(i);
                windows.Object.Item(idx.Detached, out var folderObj);
                var folder = new ComObject<DirectN.IDispatch>(folderObj);
                if (folder == null)
                    continue;

                var sp = folder.As<DirectN.IServiceProvider>();
                if (sp == null)
                    continue;

                sp.Object.QueryService(Constants.SID_STopLevelBrowser, typeof(IShellBrowser).GUID, out var ppv);
                var browser = DirectN.Extensions.Com.ComObject.FromPointer<IShellBrowser>(ppv);
                if (browser == null)
                    continue;

                browser.Object.QueryActiveShellView(out var shellView);
                if (shellView == null)
                    continue;

                var view = new ShellView(folder, shellView, true);
                yield return view;
            }
        }
    }

    private static void CheckSTAThread()
    {
        if (Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
            throw new InvalidOperationException("The current thread is not in STA mode.");
    }

    private static ShellView? GetDesktop()
    {
        CheckSTAThread();
        using var windows = DirectN.Extensions.Com.ComObject.CoCreate<IShellWindows>(Constants.ShellWindows);
        if (windows == null)
            return null;

        using var loc = new Variant(Constants.CSIDL_DESKTOP);
        var hr = windows.Object.FindWindowSW(loc.Detached, new VARIANT(), ShellWindowTypeConstants.SWC_DESKTOP, out var hwnd, ShellWindowFindWindowOptions.SWFO_NEEDDISPATCH, out var obj);
        if (obj == null)
            return null;

        using var disp = new ComObject<DirectN.IDispatch>(obj, releaseOnDispose: false);
        var sp = disp.As<DirectN.IServiceProvider>();
        if (sp == null)
            return null;

        hr = sp.Object.QueryService(Constants.SID_STopLevelBrowser, typeof(IShellBrowser).GUID, out var ppv);
        var browser = DirectN.Extensions.Com.ComObject.FromPointer<IShellBrowser>(ppv);
        if (browser == null)
            return null;

        browser.Object.QueryActiveShellView(out var view);
        if (view == null)
            return null;

        return new ShellView(disp, view, false);
    }

    private ShellView(IComObject<DirectN.IDispatch>? dispatch, IShellView comObject, bool owned)
        : this(dispatch, new ComObject<IShellView>(comObject), owned)
    {
    }

    private ShellView(IComObject<DirectN.IDispatch>? dispatch, IComObject<IShellView> comObject, bool owned)
        : base(comObject)
    {
        Dispatch = dispatch;
        Owned = owned;
    }

    public IComObject<DirectN.IDispatch>? Dispatch { get; }
    public bool Owned { get; }
    public HWND Hwnd { get { NativeObject.GetWindow(out var hwnd); return hwnd; } }
    public Window? Window => Window.FromHandle(Hwnd, false);

    public ShellFolder? GetFolder(bool owned = true)
    {
        var folderView = ComObject.As<IFolderView>();
        if (folderView == null)
            return null;

        folderView.Object.GetFolder(typeof(IShellFolder).GUID, out var ppv);
        if (ppv == 0)
            return null;

        var shellFolder = DirectN.Extensions.Com.ComObject.ComWrappers.GetOrCreateObjectForComInstance(ppv, CreateObjectFlags.UniqueInstance);
        if (shellFolder == null)
            return null;

        return ShellItem.FromObject(shellFolder, false, owned) as ShellFolder;
    }

    public HRESULT UIActivate(SVUIA_STATUS status, bool throwOnError = true) => NativeObject.UIActivate((uint)status).ThrowOnError(throwOnError);
    public HRESULT Refresh(bool throwOnError = true) => NativeObject.Refresh().ThrowOnError(throwOnError);

    protected override void Dispose(bool disposing)
    {
        if (!Owned)
            return;

        base.Dispose(disposing);
    }
}
