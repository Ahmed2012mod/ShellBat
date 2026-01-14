#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shappmgr/nn-shappmgr-ipublishedapp2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("12b81347-1b3a-4a04-aa61-3f768b67fd7e")]
public partial interface IPublishedApp2 : IPublishedApp
{
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-ipublishedapp2-install2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Install2(in SYSTEMTIME pstInstall, HWND hwndParent);
}
