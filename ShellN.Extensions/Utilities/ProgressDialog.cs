namespace ShellN.Extensions.Utilities;

public class ProgressDialog : InterlockedComObject<IActionProgressDialog>
{
    private readonly IComObject<IActionProgress> _actionProgress;

    public ProgressDialog(nint site = 0)
        : base(DirectN.Extensions.Com.ComObject.CoCreate<IActionProgressDialog>(Constants.CLSID_ProgressDialog)!)
    {
        if (site != 0 && NativeObject is IObjectWithSite ows)
        {
            ows.SetSite(site).ThrowOnError();
        }
        _actionProgress = ComObject.As<IActionProgress>(throwOnError: true)!;
    }

    public virtual void Initialize(_SPINITF flags, string? title, string? cancelText) => NativeObject.Initialize((uint)flags, PWSTR.From(title), PWSTR.From(cancelText));
    public virtual void Stop() => NativeObject.Stop();
    public virtual void Begin(SPACTION action, _SPBEGINF flags) => _actionProgress.Object.Begin(action, (uint)flags);
    public virtual void End() => _actionProgress.Object.End();
    public virtual void UpdateActionDetail(string? detail, bool mayCompact = true) => _actionProgress.Object.UpdateText(SPTEXT.SPTEXT_ACTIONDETAIL, PWSTR.From(detail), mayCompact);
    public virtual void UpdateActionDescription(string? description, bool mayCompact = true) => _actionProgress.Object.UpdateText(SPTEXT.SPTEXT_ACTIONDESCRIPTION, PWSTR.From(description), mayCompact);
    public virtual void UpdateProgress(ulong completed, ulong total) => _actionProgress.Object.UpdateProgress(completed, total);
    public virtual bool QueryCancel() { _actionProgress.Object.QueryCancel(out var cancelled); return cancelled; }
    public virtual void ResetCancel() => _actionProgress.Object.ResetCancel();

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (RawNativeObject is IObjectWithSite ows)
            {
                ows.SetSite(0);
            }
        }
        base.Dispose(disposing);
    }
}
