#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledeviceproperties
[GeneratedComInterface, Guid("7f6d695c-03df-4439-a809-59266beee3a6")]
public partial interface IPortableDeviceProperties
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceproperties-getsupportedproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedProperties(PWSTR pszObjectID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] out IPortableDeviceKeyCollection ppKeys);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceproperties-getpropertyattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyAttributes(PWSTR pszObjectID, in PROPERTYKEY Key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceproperties-getvalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValues(PWSTR pszObjectID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] IPortableDeviceKeyCollection pKeys, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppValues);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceproperties-setvalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValues(PWSTR pszObjectID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pValues, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppResults);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceproperties-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete(PWSTR pszObjectID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] IPortableDeviceKeyCollection pKeys);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceproperties-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
}
