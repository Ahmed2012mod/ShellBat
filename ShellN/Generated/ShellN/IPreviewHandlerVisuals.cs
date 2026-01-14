#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ipreviewhandlervisuals
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("196bf9a5-b346-4ef0-aa1e-5dcdb76768b1")]
public partial interface IPreviewHandlerVisuals
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandlervisuals-setbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackgroundColor(COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandlervisuals-setfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFont(in LOGFONTW plf);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipreviewhandlervisuals-settextcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextColor(COLORREF color);
}
