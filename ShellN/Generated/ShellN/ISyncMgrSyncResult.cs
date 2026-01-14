#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrsyncresult
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2b90f17e-5a3e-4b33-bb7f-1bc48056b94d")]
public partial interface ISyncMgrSyncResult
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncresult-result
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Result(SYNCMGR_PROGRESS_STATUS nStatus, uint cError, uint cConflicts);
}
