#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-itaskbarlist2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("602d4995-b13a-429b-a66e-1935e44f4317")]
public partial interface ITaskbarList2 : ITaskbarList
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist2-markfullscreenwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MarkFullscreenWindow(HWND hwnd, BOOL fFullscreen);
}
