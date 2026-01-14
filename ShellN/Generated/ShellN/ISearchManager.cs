#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-isearchmanager
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ab310581-ac80-11d1-8df3-00c04fb6ef69")]
public partial interface ISearchManager
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-getindexerversionstr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndexerVersionStr(out PWSTR ppszVersionString);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-getindexerversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndexerVersion(out uint pdwMajor, out uint pdwMinor);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-getparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParameter(PWSTR pszName, out nint ppValue);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-setparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParameter(PWSTR pszName, in PROPVARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-get_proxyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProxyName(out PWSTR ppszProxyName);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-get_bypasslist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BypassList(out PWSTR ppszBypassList);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-setproxy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProxy(PROXY_ACCESS sUseProxy, BOOL fLocalByPassProxy, uint dwPortNumber, PWSTR pszProxyName, PWSTR pszByPassList);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-getcatalog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCatalog(PWSTR pszCatalog, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISearchCatalogManager>))] out ISearchCatalogManager ppCatalogManager);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-get_useragent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UserAgent(out PWSTR ppszUserAgent);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-put_useragent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UserAgent(PWSTR pszUserAgent);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-get_useproxy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UseProxy(out PROXY_ACCESS pUseProxy);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-get_localbypass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LocalBypass(out BOOL pfLocalBypass);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchmanager-get_portnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PortNumber(out uint pdwPortNumber);
}
