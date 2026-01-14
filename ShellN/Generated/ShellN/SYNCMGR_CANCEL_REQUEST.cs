#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ne-syncmgr-syncmgr_cancel_request
public enum SYNCMGR_CANCEL_REQUEST
{
    SYNCMGR_CR_NONE = 0,
    SYNCMGR_CR_CANCEL_ITEM = 1,
    SYNCMGR_CR_CANCEL_ALL = 2,
    SYNCMGR_CR_MAX = 2,
}
