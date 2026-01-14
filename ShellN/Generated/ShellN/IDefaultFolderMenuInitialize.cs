#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-idefaultfoldermenuinitialize
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("7690aa79-f8fc-4615-a327-36f7d18f5d91")]
public partial interface IDefaultFolderMenuInitialize
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idefaultfoldermenuinitialize-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IContextMenuCB?>))] IContextMenuCB? pcmcb, nint /* optional nint* */ pidlFolder, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolder?>))] IShellFolder? psf, uint cidl, [In][Out][MarshalUsing(CountElementName = nameof(cidl))] nint[] apidl, nint punkAssociation, uint cKeys, nint /* optional HKEY* */ aKeys);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idefaultfoldermenuinitialize-setmenurestrictions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMenuRestrictions(DEFAULT_FOLDER_MENU_RESTRICTIONS dfmrValues);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idefaultfoldermenuinitialize-getmenurestrictions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMenuRestrictions(DEFAULT_FOLDER_MENU_RESTRICTIONS dfmrMask, out DEFAULT_FOLDER_MENU_RESTRICTIONS pdfmrValues);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idefaultfoldermenuinitialize-sethandlerclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHandlerClsid(in Guid rclsid);
}
