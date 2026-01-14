#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ne-syncmgr-syncmgr_progress_status
public enum SYNCMGR_PROGRESS_STATUS
{
    SYNCMGR_PS_UPDATING = 1,
    SYNCMGR_PS_UPDATING_INDETERMINATE = 2,
    SYNCMGR_PS_SUCCEEDED = 3,
    SYNCMGR_PS_FAILED = 4,
    SYNCMGR_PS_CANCELED = 5,
    SYNCMGR_PS_DISCONNECTED = 6,
    SYNCMGR_PS_MAX = 6,
}
