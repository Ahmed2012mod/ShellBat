#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ne-syncmgr-syncmgr_resolution_abilities
public enum SYNCMGR_RESOLUTION_ABILITIES
{
    SYNCMGR_RA_KEEPOTHER = 1,
    SYNCMGR_RA_KEEPRECENT = 2,
    SYNCMGR_RA_REMOVEFROMSYNCSET = 4,
    SYNCMGR_RA_KEEP_SINGLE = 8,
    SYNCMGR_RA_KEEP_MULTIPLE = 16,
    SYNCMGR_RA_VALID = 31,
}
