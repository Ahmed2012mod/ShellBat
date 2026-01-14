#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ne-syncmgr-syncmgr_control_flags
public enum SYNCMGR_CONTROL_FLAGS
{
    SYNCMGR_CF_NONE = 0,
    SYNCMGR_CF_NOWAIT = 0,
    SYNCMGR_CF_WAIT = 1,
    SYNCMGR_CF_NOUI = 2,
    SYNCMGR_CF_VALID = 3,
}
