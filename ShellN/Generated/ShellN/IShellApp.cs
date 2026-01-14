#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shappmgr/nn-shappmgr-ishellapp
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a3e14960-935f-11d1-b8b8-006008059382")]
public partial interface IShellApp
{
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ishellapp-getappinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAppInfo(ref APPINFODATA pai);
    
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ishellapp-getpossibleactions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPossibleActions(out uint pdwActions);
    
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ishellapp-getslowappinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSlowAppInfo(out SLOWAPPINFO psaid);
    
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ishellapp-getcachedslowappinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCachedSlowAppInfo(out SLOWAPPINFO psaid);
    
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ishellapp-isinstalled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsInstalled();
}
