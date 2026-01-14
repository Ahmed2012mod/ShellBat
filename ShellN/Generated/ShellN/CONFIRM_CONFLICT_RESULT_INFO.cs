#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ns-syncmgr-confirm_conflict_result_info
public partial struct CONFIRM_CONFLICT_RESULT_INFO
{
    public PWSTR pszNewName;
    public uint iItemIndex;
}
