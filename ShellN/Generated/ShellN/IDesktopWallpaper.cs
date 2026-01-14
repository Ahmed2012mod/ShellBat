#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-idesktopwallpaper
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("b92b56a9-8b55-4e14-9a89-0199bbb6f93b")]
public partial interface IDesktopWallpaper
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-setwallpaper
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWallpaper(PWSTR monitorID, PWSTR wallpaper);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-getwallpaper
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWallpaper(PWSTR monitorID, out PWSTR wallpaper);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-getmonitordevicepathat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMonitorDevicePathAt(uint monitorIndex, out PWSTR monitorID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-getmonitordevicepathcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMonitorDevicePathCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-getmonitorrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMonitorRECT(PWSTR monitorID, out RECT displayRect);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-setbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackgroundColor(COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-getbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackgroundColor(out COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-setposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPosition(DESKTOP_WALLPAPER_POSITION position);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-getposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPosition(out DESKTOP_WALLPAPER_POSITION position);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-setslideshow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSlideshow([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray items);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-getslideshow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSlideshow([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] out IShellItemArray items);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-setslideshowoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS options, uint slideshowTick);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-getslideshowoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSlideshowOptions(out DESKTOP_SLIDESHOW_OPTIONS options, out uint slideshowTick);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-advanceslideshow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AdvanceSlideshow(PWSTR monitorID, DESKTOP_SLIDESHOW_DIRECTION direction);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out DESKTOP_SLIDESHOW_STATE state);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enable(BOOL enable);
}
