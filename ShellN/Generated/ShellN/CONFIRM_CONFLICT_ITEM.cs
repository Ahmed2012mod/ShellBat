#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ns-syncmgr-confirm_conflict_item
public partial struct CONFIRM_CONFLICT_ITEM
{
    public nint pShellItem;
    public PWSTR pszOriginalName;
    public PWSTR pszAlternateName;
    public PWSTR pszLocationShort;
    public PWSTR pszLocationFull;
    public SYNCMGR_CONFLICT_ITEM_TYPE nType;
}
