#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ipreviewhandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8895b1c6-b41f-4c1c-a562-0d564250836f")]
public partial interface IPreviewHandler
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandler-setwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWindow(HWND hwnd, in RECT prc);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandler-setrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRect(in RECT prc);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandler-dopreview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoPreview();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandler-unload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unload();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandler-setfocus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFocus();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandler-queryfocus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryFocus(out HWND phwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandler-translateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAccelerator(in MSG pmsg);
}
