#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellfolder
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214e6-0000-0000-c000-000000000046")]
public partial interface IShellFolder
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-parsedisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseDisplayName(HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, PWSTR pszDisplayName, nint /* optional uint* */ pchEaten, out nint ppidl, ref uint pdwAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-enumobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumObjects(HWND hwnd, uint grfFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumIDList>))] out IEnumIDList ppenumIDList);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-bindtoobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToObject(nint pidl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-bindtostorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToStorage(nint pidl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-compareids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompareIDs(LPARAM lParam, nint pidl1, nint pidl2);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-createviewobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateViewObject(HWND hwndOwner, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-getattributesof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributesOf(uint cidl, [In][Out][MarshalUsing(CountElementName = nameof(cidl))] nint[] apidl, ref uint rgfInOut);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-getuiobjectof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUIObjectOf(HWND hwndOwner, uint cidl, [In][Out][MarshalUsing(CountElementName = nameof(cidl))] nint[] apidl, in Guid riid, nint /* optional uint* */ rgfReserved, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-getdisplaynameof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayNameOf(nint pidl, SHGDNF uFlags, out STRRET pName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-setnameof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNameOf(HWND hwnd, nint pidl, PWSTR pszName, SHGDNF uFlags, nint /* optional nint** */ ppidlOut);
}
