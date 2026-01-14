#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertychangearray
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("380f5cad-1b5e-42f2-805d-637fd392d31e")]
public partial interface IPropertyChangeArray
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertychangearray-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcOperations);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertychangearray-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint iIndex, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertychangearray-insertat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertAt(uint iIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyChange>))] IPropertyChange ppropChange);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertychangearray-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Append([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyChange>))] IPropertyChange ppropChange);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertychangearray-appendorreplace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendOrReplace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyChange>))] IPropertyChange ppropChange);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertychangearray-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAt(uint iIndex);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertychangearray-iskeyinarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsKeyInArray(in PROPERTYKEY key);
}
