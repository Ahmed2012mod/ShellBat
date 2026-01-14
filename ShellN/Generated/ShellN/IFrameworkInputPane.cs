#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iframeworkinputpane
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("5752238b-24f0-495a-82f1-2fd593056796")]
public partial interface IFrameworkInputPane
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iframeworkinputpane-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise(nint pWindow, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFrameworkInputPaneHandler>))] IFrameworkInputPaneHandler pHandler, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iframeworkinputpane-advisewithhwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AdviseWithHWND(HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFrameworkInputPaneHandler>))] IFrameworkInputPaneHandler pHandler, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iframeworkinputpane-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iframeworkinputpane-location
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Location(out RECT prcInputPaneScreenLocation);
}
