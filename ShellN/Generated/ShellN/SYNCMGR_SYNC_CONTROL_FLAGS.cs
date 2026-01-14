#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ne-syncmgr-syncmgr_sync_control_flags
public enum SYNCMGR_SYNC_CONTROL_FLAGS
{
    SYNCMGR_SCF_NONE = 0,
    SYNCMGR_SCF_IGNORE_IF_ALREADY_SYNCING = 1,
    SYNCMGR_SCF_VALID = 1,
}
