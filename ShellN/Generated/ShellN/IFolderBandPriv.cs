#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ifolderbandpriv
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("47c01f95-e185-412c-b5c5-4f27df965aea")]
public partial interface IFolderBandPriv
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifolderbandpriv-setcascade
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCascade(BOOL fCascade);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifolderbandpriv-setaccelerators
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAccelerators(BOOL fAccelerators);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifolderbandpriv-setnoicons
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNoIcons(BOOL fNoIcons);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifolderbandpriv-setnotext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNoText(BOOL fNoText);
}
