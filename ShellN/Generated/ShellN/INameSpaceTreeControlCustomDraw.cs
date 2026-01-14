#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-inamespacetreecontrolcustomdraw
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2d3ba758-33ee-42d5-bb7b-5f3431d86c78")]
public partial interface INameSpaceTreeControlCustomDraw
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontrolcustomdraw-prepaint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrePaint(HDC hdc, in RECT prc, out LRESULT plres);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontrolcustomdraw-postpaint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostPaint(HDC hdc, in RECT prc);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontrolcustomdraw-itemprepaint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ItemPrePaint(HDC hdc, in RECT prc, in NSTCCUSTOMDRAW pnstccdItem, ref COLORREF pclrText, ref COLORREF pclrTextBk, out LRESULT plres);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontrolcustomdraw-itempostpaint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ItemPostPaint(HDC hdc, in RECT prc, in NSTCCUSTOMDRAW pnstccdItem);
}
