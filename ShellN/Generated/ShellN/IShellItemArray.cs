#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellitemarray
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b63ea76d-1f85-456f-a19c-48159efa858b")]
public partial interface IShellItemArray
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-bindtohandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToHandler([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, in Guid bhid, in Guid riid, out nint /* void */ ppvOut);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getpropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyStore(GETPROPERTYSTOREFLAGS flags, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getpropertydescriptionlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyDescriptionList(in PROPERTYKEY keyType, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributes(SIATTRIBFLAGS AttribFlags, SFGAO_FLAGS sfgaoMask, out SFGAO_FLAGS psfgaoAttribs);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pdwNumItems);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-getitemat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemAt(uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem ppsi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemarray-enumitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumShellItems>))] out IEnumShellItems ppenumShellItems);
}
