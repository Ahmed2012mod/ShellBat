#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ivirtualdesktopmanager
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("a5cd92ff-29be-454c-8d04-d82879fb3f1b")]
public partial interface IVirtualDesktopManager
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ivirtualdesktopmanager-iswindowoncurrentvirtualdesktop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsWindowOnCurrentVirtualDesktop(HWND topLevelWindow, out BOOL onCurrentDesktop);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ivirtualdesktopmanager-getwindowdesktopid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindowDesktopId(HWND topLevelWindow, out Guid desktopId);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ivirtualdesktopmanager-movewindowtodesktop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveWindowToDesktop(HWND topLevelWindow, in Guid desktopId);
}
