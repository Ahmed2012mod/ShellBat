#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledeviceresources
[GeneratedComInterface, Guid("fd8878ac-d841-4d17-891c-e6829cdb6934")]
public partial interface IPortableDeviceResources
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceresources-getsupportedresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedResources(PWSTR pszObjectID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] out IPortableDeviceKeyCollection ppKeys);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceresources-getresourceattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceAttributes(PWSTR pszObjectID, in PROPERTYKEY Key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppResourceAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceresources-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream(PWSTR pszObjectID, in PROPERTYKEY Key, uint dwMode, ref uint pdwOptimalBufferSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppStream);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceresources-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete(PWSTR pszObjectID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] IPortableDeviceKeyCollection pKeys);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceresources-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceresources-createresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pResourceAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppData, ref uint pdwOptimalWriteBufferSize, out PWSTR ppszCookie);
}
