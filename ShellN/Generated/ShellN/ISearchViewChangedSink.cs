#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-isearchviewchangedsink
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ab310581-ac80-11d1-8df3-00c04fb6ef65")]
public partial interface ISearchViewChangedSink
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchviewchangedsink-onchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnChange(in int pdwDocID, in SEARCH_ITEM_CHANGE pChange, in BOOL pfInView);
}
