#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ne-syncmgr-syncmgr_presenter_next_step
public enum SYNCMGR_PRESENTER_NEXT_STEP
{
    SYNCMGR_PNS_CONTINUE = 0,
    SYNCMGR_PNS_DEFAULT = 1,
    SYNCMGR_PNS_CANCEL = 2,
}
