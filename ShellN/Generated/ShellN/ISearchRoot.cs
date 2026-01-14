#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-isearchroot
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("04c18ccf-1f57-4cbd-88cc-3900f5195ce3")]
public partial interface ISearchRoot
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_schedule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Schedule(PWSTR pszTaskArg);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_schedule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Schedule(out PWSTR ppszTaskArg);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_rooturl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RootURL(PWSTR pszURL);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_rooturl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RootURL(out PWSTR ppszURL);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_ishierarchical
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IsHierarchical(BOOL fIsHierarchical);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_ishierarchical
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsHierarchical(out BOOL pfIsHierarchical);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_providesnotifications
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ProvidesNotifications(BOOL fProvidesNotifications);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_providesnotifications
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProvidesNotifications(out BOOL pfProvidesNotifications);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_usenotificationsonly
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UseNotificationsOnly(BOOL fUseNotificationsOnly);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_usenotificationsonly
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UseNotificationsOnly(out BOOL pfUseNotificationsOnly);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_enumerationdepth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EnumerationDepth(uint dwDepth);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_enumerationdepth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnumerationDepth(out uint pdwDepth);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_hostdepth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HostDepth(uint dwDepth);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_hostdepth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HostDepth(out uint pdwDepth);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_followdirectories
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FollowDirectories(BOOL fFollowDirectories);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_followdirectories
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FollowDirectories(out BOOL pfFollowDirectories);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_authenticationtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AuthenticationType(AUTH_TYPE authType);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_authenticationtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AuthenticationType(out AUTH_TYPE pAuthType);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_user
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_User(PWSTR pszUser);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_user
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_User(out PWSTR ppszUser);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-put_password
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Password(PWSTR pszPassword);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchroot-get_password
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Password(out PWSTR ppszPassword);
}
