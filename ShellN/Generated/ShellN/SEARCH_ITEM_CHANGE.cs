#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/ns-searchapi-search_item_change
public partial struct SEARCH_ITEM_CHANGE
{
    public SEARCH_KIND_OF_CHANGE Change;
    public SEARCH_NOTIFICATION_PRIORITY Priority;
    public nint pUserData;
    public PWSTR lpwszURL;
    public PWSTR lpwszOldURL;
}
