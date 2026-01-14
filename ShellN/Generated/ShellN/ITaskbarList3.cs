#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-itaskbarlist3
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")]
public partial interface ITaskbarList3 : ITaskbarList2
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-setprogressvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProgressValue(HWND hwnd, ulong ullCompleted, ulong ullTotal);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-setprogressstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProgressState(HWND hwnd, TBPFLAG tbpFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-registertab
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterTab(HWND hwndTab, HWND hwndMDI);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-unregistertab
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterTab(HWND hwndTab);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-settaborder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTabOrder(HWND hwndTab, HWND hwndInsertBefore);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-settabactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTabActive(HWND hwndTab, HWND hwndMDI, uint dwReserved);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-thumbbaraddbuttons
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ThumbBarAddButtons(HWND hwnd, uint cButtons, [In][MarshalUsing(CountElementName = nameof(cButtons))] THUMBBUTTON[] pButton);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-thumbbarupdatebuttons
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ThumbBarUpdateButtons(HWND hwnd, uint cButtons, [In][MarshalUsing(CountElementName = nameof(cButtons))] THUMBBUTTON[] pButton);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-thumbbarsetimagelist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ThumbBarSetImageList(HWND hwnd, HIMAGELIST himl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-setoverlayicon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOverlayIcon(HWND hwnd, HICON hIcon, PWSTR pszDescription);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-setthumbnailtooltip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetThumbnailTooltip(HWND hwnd, PWSTR pszTip);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist3-setthumbnailclip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetThumbnailClip(HWND hwnd, in RECT prcClip);
}
