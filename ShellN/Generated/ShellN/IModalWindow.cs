#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-imodalwindow
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("b4db1657-70d7-485e-8e3e-6fcb5a5c1802")]
public partial interface IModalWindow
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-imodalwindow-show
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Show(HWND hwndOwner);
}
