#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ivisualproperties
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e693cf68-d967-4112-8763-99172aee5e5a")]
public partial interface IVisualProperties
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ivisualproperties-setwatermark
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWatermark(HBITMAP hbmp, VPWATERMARKFLAGS vpwf);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ivisualproperties-setcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColor(VPCOLORFLAGS vpcf, COLORREF cr);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ivisualproperties-getcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColor(VPCOLORFLAGS vpcf, out COLORREF pcr);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ivisualproperties-setitemheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetItemHeight(int cyItemInPixels);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ivisualproperties-getitemheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemHeight(out int cyItemInPixels);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ivisualproperties-setfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFont(in LOGFONTW plf, BOOL bRedraw);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ivisualproperties-getfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFont(out LOGFONTW plf);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ivisualproperties-settheme
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTheme(PWSTR pszSubAppName, PWSTR pszSubIdList);
}
