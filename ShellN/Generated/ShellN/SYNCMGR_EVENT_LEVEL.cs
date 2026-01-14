#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ne-syncmgr-syncmgr_event_level
public enum SYNCMGR_EVENT_LEVEL
{
    SYNCMGR_EL_INFORMATION = 1,
    SYNCMGR_EL_WARNING = 2,
    SYNCMGR_EL_ERROR = 3,
    SYNCMGR_EL_MAX = 3,
}
