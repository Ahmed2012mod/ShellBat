#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-idatatransfermanagerinterop
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3a3dcd6c-3eab-43dc-bcde-45671ce800c8")]
public partial interface IDataTransferManagerInterop
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idatatransfermanagerinterop-getforwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetForWindow(HWND appWindow, in Guid riid, out nint /* void */ dataTransferManager);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idatatransfermanagerinterop-showshareuiforwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowShareUIForWindow(HWND appWindow);
}
