#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellitem2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7e9fb0d3-919f-4307-ab2e-9b1860310c93")]
public partial interface IShellItem2 : IShellItem
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getpropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyStore(GETPROPERTYSTOREFLAGS flags, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getpropertystorewithcreateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyStoreWithCreateObject(GETPROPERTYSTOREFLAGS flags, nint punkCreateObject, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getpropertystoreforkeys
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyStoreForKeys([In][MarshalUsing(CountElementName = nameof(cKeys))] PROPERTYKEY[] rgKeys, uint cKeys, GETPROPERTYSTOREFLAGS flags, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getpropertydescriptionlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyDescriptionList(in PROPERTYKEY keyType, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Update([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(in PROPERTYKEY key, out PROPVARIANT ppropvar);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCLSID(in PROPERTYKEY key, out Guid pclsid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getfiletime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileTime(in PROPERTYKEY key, out FILETIME pft);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getint32
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInt32(in PROPERTYKEY key, out int pi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetString(in PROPERTYKEY key, out PWSTR ppsz);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getuint32
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUInt32(in PROPERTYKEY key, out uint pui);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getuint64
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUInt64(in PROPERTYKEY key, out ulong pull);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitem2-getbool
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBool(in PROPERTYKEY key, out BOOL pf);
}
