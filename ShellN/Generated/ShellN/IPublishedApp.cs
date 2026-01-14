#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shappmgr/nn-shappmgr-ipublishedapp
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1bc752e0-9046-11d1-b8b3-006008059382")]
public partial interface IPublishedApp : IShellApp
{
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ipublishedapp-install
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Install(in SYSTEMTIME pstInstall);
    
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ipublishedapp-getpublishedappinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPublishedAppInfo(ref PUBAPPINFO ppai);
    
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ipublishedapp-unschedule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unschedule();
}
