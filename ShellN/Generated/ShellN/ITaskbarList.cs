#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-itaskbarlist
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56fdf342-fd6d-11d0-958a-006097c9a090")]
public partial interface ITaskbarList
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist-hrinit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HrInit();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist-addtab
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTab(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist-deletetab
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteTab(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist-activatetab
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateTab(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-itaskbarlist-setactivealt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActiveAlt(HWND hwnd);
}
