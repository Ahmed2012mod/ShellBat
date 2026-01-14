#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/ns-searchapi-search_item_indexing_status
public partial struct SEARCH_ITEM_INDEXING_STATUS
{
    public uint dwDocID;
    public HRESULT hrIndexingStatus;
}
