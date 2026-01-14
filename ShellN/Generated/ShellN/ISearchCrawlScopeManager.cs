#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-isearchcrawlscopemanager
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ab310581-ac80-11d1-8df3-00c04fb6ef55")]
public partial interface ISearchCrawlScopeManager
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-adddefaultscoperule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDefaultScopeRule(PWSTR pszURL, BOOL fInclude, uint fFollowFlags);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-addroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRoot([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISearchRoot>))] ISearchRoot pSearchRoot);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-removeroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveRoot(PWSTR pszURL);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-enumerateroots
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateRoots([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSearchRoots>))] out IEnumSearchRoots ppSearchRoots);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-addhierarchicalscope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddHierarchicalScope(PWSTR pszURL, BOOL fInclude, BOOL fDefault, BOOL fOverrideChildren);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-adduserscoperule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddUserScopeRule(PWSTR pszURL, BOOL fInclude, BOOL fOverrideChildren, uint fFollowFlags);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-removescoperule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveScopeRule(PWSTR pszRule);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-enumeratescoperules
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateScopeRules([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSearchScopeRules>))] out IEnumSearchScopeRules ppSearchScopeRules);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-hasparentscoperule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasParentScopeRule(PWSTR pszURL, out BOOL pfHasParentRule);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-haschildscoperule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasChildScopeRule(PWSTR pszURL, out BOOL pfHasChildRule);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-includedincrawlscope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IncludedInCrawlScope(PWSTR pszURL, out BOOL pfIsIncluded);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-includedincrawlscopeex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IncludedInCrawlScopeEx(PWSTR pszURL, out BOOL pfIsIncluded, out CLUSION_REASON pReason);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-reverttodefaultscopes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RevertToDefaultScopes();
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-saveall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveAll();
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-getparentscopeversionid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParentScopeVersionId(PWSTR pszURL, out int plScopeId);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchcrawlscopemanager-removedefaultscoperule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveDefaultScopeRule(PWSTR pszURL);
}
