#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iexplorerbrowser
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("dfd3b6b5-c10c-4be9-85f6-a66969f402f6")]
public partial interface IExplorerBrowser
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(HWND hwndParent, in RECT prc, nint /* optional FOLDERSETTINGS* */ pfs);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-destroy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Destroy();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-setrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRect(nint /* optional HDWP* */ phdwp, RECT rcBrowser);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-setpropertybag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPropertyBag(PWSTR pszPropertyBag);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-setemptytext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEmptyText(PWSTR pszEmptyText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-setfoldersettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFolderSettings(in FOLDERSETTINGS pfs);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IExplorerBrowserEvents>))] IExplorerBrowserEvents psbe, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-setoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOptions(EXPLORER_BROWSER_OPTIONS dwFlag);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-getoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOptions(out EXPLORER_BROWSER_OPTIONS pdwFlag);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-browsetoidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BrowseToIDList(nint pidl, uint uFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-browsetoobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BrowseToObject(nint punk, uint uFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-fillfromobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FillFromObject(nint punk, EXPLORER_BROWSER_FILL_FLAGS dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-removeall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAll();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowser-getcurrentview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentView(in Guid riid, out nint /* void */ ppv);
}
