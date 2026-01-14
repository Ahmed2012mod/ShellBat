#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iactionprogress
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("49ff1173-eadc-446d-9285-156453a6431c")]
public partial interface IActionProgress
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iactionprogress-begin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Begin(SPACTION action, uint flags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iactionprogress-updateprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateProgress(ulong ulCompleted, ulong ulTotal);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iactionprogress-updatetext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateText(SPTEXT sptext, PWSTR pszText, BOOL fMayCompact);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iactionprogress-querycancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryCancel(out BOOL pfCancelled);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iactionprogress-resetcancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetCancel();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iactionprogress-end
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT End();
}
