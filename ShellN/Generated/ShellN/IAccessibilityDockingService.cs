#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iaccessibilitydockingservice
[GeneratedComInterface, Guid("8849dc22-cedf-4c95-998d-051419dd3f76")]
public partial interface IAccessibilityDockingService
{
    // https://learn.microsoft.com/windows/win32/com/iaccessibilitydockingservice-getavailablesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableSize(HMONITOR hMonitor, out uint pcxFixed, out uint pcyMax);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iaccessibilitydockingservice-dockwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DockWindow(HWND hwnd, HMONITOR hMonitor, uint cyRequested, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAccessibilityDockingServiceCallback>))] IAccessibilityDockingServiceCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iaccessibilitydockingservice-undockwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UndockWindow(HWND hwnd);
}
