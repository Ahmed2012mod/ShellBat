#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellitem
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("43826d1e-e718-42ee-bc55-a1e261c37bfe")]
public partial interface IShellItem
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem-bindtohandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToHandler([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, in Guid bhid, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem-getparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem ppsi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem-getdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayName(SIGDN sigdnName, out PWSTR ppszName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem-getattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributes(SFGAO_FLAGS sfgaoMask, out SFGAO_FLAGS psfgaoAttribs);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem-compare
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Compare([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, uint hint, out int piOrder);
}
