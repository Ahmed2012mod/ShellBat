#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ne-syncmgr-syncmgr_conflict_item_type
public enum SYNCMGR_CONFLICT_ITEM_TYPE
{
    SYNCMGR_CIT_UPDATED = 1,
    SYNCMGR_CIT_DELETED = 2,
}
