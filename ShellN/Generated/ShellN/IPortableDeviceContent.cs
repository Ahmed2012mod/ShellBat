#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledevicecontent
[GeneratedComInterface, Guid("6a96ed84-7c73-4480-9938-bf5af477d426")]
public partial interface IPortableDeviceContent
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent-enumobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumObjects(uint dwFlags, PWSTR pszParentObjectID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pFilter, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumPortableDeviceObjectIDs>))] out IEnumPortableDeviceObjectIDs ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent-properties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Properties([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceProperties>))] out IPortableDeviceProperties ppProperties);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent-transfer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Transfer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceResources>))] out IPortableDeviceResources ppResources);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent-createobjectwithpropertiesonly
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateObjectWithPropertiesOnly([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pValues, out PWSTR ppszObjectID);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent-createobjectwithpropertiesanddata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateObjectWithPropertiesAndData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pValues, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppData, ref uint pdwOptimalWriteBufferSize, out PWSTR ppszCookie);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete(uint dwOptions, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] IPortableDevicePropVariantCollection pObjectIDs, ref IPortableDevicePropVariantCollection ppResults);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent-getobjectidsfrompersistentuniqueids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectIDsFromPersistentUniqueIDs([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] IPortableDevicePropVariantCollection pPersistentUniqueIDs, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppObjectIDs);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent-move
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Move([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] IPortableDevicePropVariantCollection pObjectIDs, PWSTR pszDestinationFolderObjectID, ref IPortableDevicePropVariantCollection ppResults);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent-copy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Copy([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] IPortableDevicePropVariantCollection pObjectIDs, PWSTR pszDestinationFolderObjectID, ref IPortableDevicePropVariantCollection ppResults);
}
