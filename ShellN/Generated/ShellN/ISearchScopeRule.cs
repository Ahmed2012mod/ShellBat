#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-isearchscoperule
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ab310581-ac80-11d1-8df3-00c04fb6ef53")]
public partial interface ISearchScopeRule
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchscoperule-get_patternorurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PatternOrURL(out PWSTR ppszPatternOrURL);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchscoperule-get_isincluded
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsIncluded(out BOOL pfIsIncluded);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchscoperule-get_isdefault
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsDefault(out BOOL pfIsDefault);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchscoperule-get_followflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FollowFlags(out uint pFollowFlags);
}
