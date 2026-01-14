#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellbrowser
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214e2-0000-0000-c000-000000000046")]
public partial interface IShellBrowser : IOleWindow
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-insertmenussb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertMenusSB(HMENU hmenuShared, ref OLEMENUGROUPWIDTHS lpMenuWidths);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-setmenusb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMenuSB(HMENU hmenuShared, nint holemenuRes, HWND hwndActiveObject);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-removemenussb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveMenusSB(HMENU hmenuShared);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-setstatustextsb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStatusTextSB(PWSTR pszStatusText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-enablemodelesssb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableModelessSB(BOOL fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-translateacceleratorsb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAcceleratorSB(in MSG pmsg, ushort wID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-browseobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BrowseObject(nint pidl, uint wFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-getviewstatestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewStateStream(uint grfMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppStrm);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-getcontrolwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControlWindow(uint id, out HWND phwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-sendcontrolmsg
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendControlMsg(uint id, uint uMsg, WPARAM wParam, LPARAM lParam, nint /* optional LRESULT* */ pret);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-queryactiveshellview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryActiveShellView([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] out IShellView ppshv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-onviewwindowactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnViewWindowActive([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView pshv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellbrowser-settoolbaritems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetToolbarItems(nint /* optional TBBUTTON* */ lpButtons, uint nButtons, uint uFlags);
}
