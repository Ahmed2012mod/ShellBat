#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-isearchcatalogmanager
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ab310581-ac80-11d1-8df3-00c04fb6ef50")]
public partial interface ISearchCatalogManager
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-get_name
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out PWSTR pszName);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-getparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParameter(PWSTR pszName, out nint ppValue);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-setparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParameter(PWSTR pszName, in PROPVARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-getcatalogstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCatalogStatus(out CatalogStatus pStatus, out CatalogPausedReason pPausedReason);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-reindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reindex();
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-reindexmatchingurls
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReindexMatchingURLs(PWSTR pszPattern);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-reindexsearchroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReindexSearchRoot(PWSTR pszRootURL);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-put_connecttimeout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ConnectTimeout(uint dwConnectTimeout);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-get_connecttimeout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ConnectTimeout(out uint pdwConnectTimeout);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-put_datatimeout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DataTimeout(uint dwDataTimeout);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-get_datatimeout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DataTimeout(out uint pdwDataTimeout);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-numberofitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NumberOfItems(out int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-numberofitemstoindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NumberOfItemsToIndex(out int plIncrementalCount, out int plNotificationQueue, out int plHighPriorityQueue);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-urlbeingindexed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT URLBeingIndexed(out PWSTR pszUrl);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-geturlindexingstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetURLIndexingState(PWSTR pszURL, out uint pdwState);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-getpersistentitemschangedsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPersistentItemsChangedSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISearchPersistentItemsChangedSink>))] out ISearchPersistentItemsChangedSink ppISearchPersistentItemsChangedSink);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-registerviewfornotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterViewForNotification(PWSTR pszView, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISearchViewChangedSink>))] ISearchViewChangedSink pViewChangedSink, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-getitemschangedsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemsChangedSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISearchNotifyInlineSite>))] ISearchNotifyInlineSite pISearchNotifyInlineSite, in Guid riid, out nint /* void */ ppv, out Guid pGUIDCatalogResetSignature, out Guid pGUIDCheckPointSignature, out uint pdwLastCheckPointNumber);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-unregisterviewfornotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterViewForNotification(uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-setextensionclusion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetExtensionClusion(PWSTR pszExtension, BOOL fExclude);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-enumerateexcludedextensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateExcludedExtensions([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumString>))] out IEnumString ppExtensions);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-getqueryhelper
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetQueryHelper([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISearchQueryHelper>))] out ISearchQueryHelper ppSearchQueryHelper);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-put_diacriticsensitivity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DiacriticSensitivity(BOOL fDiacriticSensitive);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-get_diacriticsensitivity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DiacriticSensitivity(out BOOL pfDiacriticSensitive);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcatalogmanager-getcrawlscopemanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCrawlScopeManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISearchCrawlScopeManager>))] out ISearchCrawlScopeManager ppCrawlScopeManager);
}
