#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/ns-searchapi-search_item_persistent_change
public partial struct SEARCH_ITEM_PERSISTENT_CHANGE
{
    public SEARCH_KIND_OF_CHANGE Change;
    public PWSTR URL;
    public PWSTR OldURL;
    public SEARCH_NOTIFICATION_PRIORITY Priority;
}
