#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-isearchnotifyinlinesite
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("b5702e61-e75c-4b64-82a1-6cb4f832fccf")]
public partial interface ISearchNotifyInlineSite
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchnotifyinlinesite-onitemindexedstatuschange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnItemIndexedStatusChange(SEARCH_INDEXING_PHASE sipStatus, uint dwNumEntries, [In][MarshalUsing(CountElementName = nameof(dwNumEntries))] SEARCH_ITEM_INDEXING_STATUS[] rgItemStatusEntries);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchnotifyinlinesite-oncatalogstatuschange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnCatalogStatusChange(in Guid guidCatalogResetSignature, in Guid guidCheckPointSignature, uint dwLastCheckPointNumber);
}
