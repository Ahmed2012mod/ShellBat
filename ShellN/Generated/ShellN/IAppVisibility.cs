#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iappvisibility
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("2246ea2d-caea-4444-a3c4-6de827e44313")]
public partial interface IAppVisibility
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iappvisibility-getappvisibilityonmonitor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAppVisibilityOnMonitor(HMONITOR hMonitor, out MONITOR_APP_VISIBILITY pMode);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iappvisibility-islaunchervisible
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsLauncherVisible(out BOOL pfVisible);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iappvisibility-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAppVisibilityEvents>))] IAppVisibilityEvents pCallback, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iappvisibility-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(uint dwCookie);
}
