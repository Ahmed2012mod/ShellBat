namespace ShellN.Extensions;

public class ChangeNotifier : IDisposable
{
    private ChangeNotifyWindow? _notifyWindow;

    public event EventHandler<ChangeNotifyEventArgs>? Notified;

    public virtual Task Run(
        ItemIdList? idList,
        bool recursive = true,
        SHCNE_ID events = SHCNE_ID.SHCNE_ALLEVENTS,
        SHCNRF_SOURCE flags = SHCNRF_SOURCE.SHCNRF_InterruptLevel | SHCNRF_SOURCE.SHCNRF_ShellLevel) => TaskUtilities.RunWithSTAThread(() =>
    {
        Application.ExitAllOnLastWindowRemoved = false;
        using var app = new Application();
        NotifyWindow = new ChangeNotifyWindow(this, idList, recursive, events, flags);
        app.Run();
    }, true);

    protected virtual ChangeNotifyWindow? NotifyWindow { get => _notifyWindow; set => _notifyWindow = value; }
    protected virtual ChangeNotifyWindow CreateNotifyWindow(ItemIdList? idlist, bool recursive, SHCNE_ID events, SHCNRF_SOURCE flags) => new(this, idlist, recursive, events, flags);

    // note: can come from any thread
    protected virtual void OnNotified(object sender, ChangeNotifyEventArgs e) => Notified?.Invoke(sender, e);

    protected class ChangeNotifyWindow : Window
    {
        public const uint WM_SHELL_NOTIFY = MessageDecoder.WM_APP + 1;

        public unsafe ChangeNotifyWindow(
            ChangeNotifier notifier,
            ItemIdList? idlist = null,
            bool recursive = true,
            SHCNE_ID events = SHCNE_ID.SHCNE_ALLEVENTS,
            SHCNRF_SOURCE flags = SHCNRF_SOURCE.SHCNRF_InterruptLevel | SHCNRF_SOURCE.SHCNRF_ShellLevel)
            : base(style: 0, extendedStyle: 0, parentHandle: HWND.MESSAGE)
        {
            ArgumentNullException.ThrowIfNull(notifier);
            Notifier = notifier;
            Idlist = idlist;
            Flags = flags;

            var entry = new SHChangeNotifyEntry
            {
                pidl = Idlist?.Pointer ?? 0,
                fRecursive = recursive
            };
            RegistrationId = Functions.SHChangeNotifyRegister(Handle, flags, (int)events, WM_SHELL_NOTIFY, 1, (nint)(&entry));
            if (RegistrationId == 0)
                throw new InvalidOperationException("Failed to register for change notifications.");
        }

        public ChangeNotifier Notifier { get; }
        public SHCNRF_SOURCE Flags { get; }
        public ItemIdList? Idlist { get; }
        public uint RegistrationId { get; }
        protected override uint AboutSysMenuId { get => 0; set { } }

        protected override void RegisterClass(string className, nint windowProc, Icon? icon = null) => RegisterWindowClass(className, windowProc, 0);
        protected override void OnDestroyed(object? sender, EventArgs e)
        {
            Functions.SHChangeNotifyDeregister(RegistrationId);
            base.OnDestroyed(sender, e);
        }

        protected override LRESULT? WindowProc(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam)
        {
            if (msg == WM_SHELL_NOTIFY)
            {
                unsafe
                {
                    if (Flags.HasFlag(SHCNRF_SOURCE.SHCNRF_NewDelivery))
                    {
                        var evt = 0;
                        nint pidls = 0;
                        var hlock = Functions.SHChangeNotification_Lock((nint)wParam.Value, (uint)lParam.Value.ToInt64(), (nint)(&pidls), (nint)(&evt));
                        if (hlock.Value != 0)
                        {
                            var array = (nint*)pidls;
                            var idl1 = ItemIdList.FromPointer(array[0], false);
                            var idl2 = ItemIdList.FromPointer(array[1], false);
                            var e = new ChangeNotifyEventArgs(idl1, idl2, (SHCNE_ID)evt);
                            Notifier.OnNotified(Notifier, e);
                            Functions.SHChangeNotification_Unlock(hlock);
                        }
                    }
                    else
                    {
                        var array = (nint*)wParam.Value;
                        var evt = (SHCNE_ID)lParam.Value;
                        var idl1 = ItemIdList.FromPointer(array[0], false);
                        var idl2 = ItemIdList.FromPointer(array[1], false);
                        var e = new ChangeNotifyEventArgs(idl1, idl2, evt);
                        Notifier.OnNotified(Notifier, e);
                    }
                }
                return 0;
            }
            return base.WindowProc(hwnd, msg, wParam, lParam);
        }
    }

    public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _notifyWindow?.Close();
        }
    }
}
