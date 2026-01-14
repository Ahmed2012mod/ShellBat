#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-idockingwindow
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("012dd920-7b26-11d0-8ca9-00a0c92dbfe8")]
public partial interface IDockingWindow : IOleWindow
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idockingwindow-showdw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowDW(BOOL fShow);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idockingwindow-closedw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloseDW(uint dwReserved);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idockingwindow-resizeborderdw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResizeBorderDW(in RECT prcBorder, nint punkToolbarSite, BOOL fReserved);
}
