#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrschedulewizarduioperation
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("459a6c84-21d2-4ddc-8a53-f023a46066f2")]
public partial interface ISyncMgrScheduleWizardUIOperation : ISyncMgrUIOperation
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrschedulewizarduioperation-initwizard
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitWizard(PWSTR pszHandlerID);
}
