#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-isearchpersistentitemschangedsink
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a2ffdf9b-4758-4f84-b729-df81a1a0612f")]
public partial interface ISearchPersistentItemsChangedSink
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchpersistentitemschangedsink-startedmonitoringscope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartedMonitoringScope(PWSTR pszURL);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchpersistentitemschangedsink-stoppedmonitoringscope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StoppedMonitoringScope(PWSTR pszURL);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchpersistentitemschangedsink-onitemschanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnItemsChanged(uint dwNumberOfChanges, [In][MarshalUsing(CountElementName = nameof(dwNumberOfChanges))] SEARCH_ITEM_PERSISTENT_CHANGE[] DataChangeEntries, [In][Out][MarshalUsing(CountElementName = nameof(dwNumberOfChanges))] HRESULT[] hrCompletionCodes);
}
