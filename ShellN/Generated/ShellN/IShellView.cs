#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellview
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214e3-0000-0000-c000-000000000046")]
public partial interface IShellView : IOleWindow
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-translateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAccelerator(in MSG pmsg);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-enablemodeless
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableModeless(BOOL fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-uiactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UIActivate(uint uState);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-refresh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Refresh();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-createviewwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateViewWindow([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView psvPrevious, in FOLDERSETTINGS pfs, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellBrowser>))] IShellBrowser psb, in RECT prcView, out HWND phWnd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-destroyviewwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DestroyViewWindow();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-getcurrentinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentInfo(out FOLDERSETTINGS pfs);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-addpropertysheetpages
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPropertySheetPages(uint dwReserved, LPFNSVADDPROPSHEETPAGE pfn, LPARAM lparam);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-saveviewstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveViewState();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-selectitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectItem(nint pidlItem, uint uFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview-getitemobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemObject(uint uItem, in Guid riid, out nint /* void */ ppv);
}
