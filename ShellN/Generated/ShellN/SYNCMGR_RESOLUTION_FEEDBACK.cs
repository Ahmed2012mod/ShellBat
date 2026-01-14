#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ne-syncmgr-syncmgr_resolution_feedback
public enum SYNCMGR_RESOLUTION_FEEDBACK
{
    SYNCMGR_RF_CONTINUE = 0,
    SYNCMGR_RF_REFRESH = 1,
    SYNCMGR_RF_CANCEL = 2,
}
