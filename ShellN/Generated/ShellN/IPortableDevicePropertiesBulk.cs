#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledevicepropertiesbulk
[GeneratedComInterface, Guid("482b05c0-4056-44ed-9e0f-5e23b009da93")]
public partial interface IPortableDevicePropertiesBulk
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicepropertiesbulk-queuegetvaluesbyobjectlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueueGetValuesByObjectList([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] IPortableDevicePropVariantCollection pObjectIDs, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] IPortableDeviceKeyCollection pKeys, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropertiesBulkCallback>))] IPortableDevicePropertiesBulkCallback pCallback, out Guid pContext);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicepropertiesbulk-queuegetvaluesbyobjectformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueueGetValuesByObjectFormat(in Guid pguidObjectFormat, PWSTR pszParentObjectID, uint dwDepth, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] IPortableDeviceKeyCollection pKeys, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropertiesBulkCallback>))] IPortableDevicePropertiesBulkCallback pCallback, out Guid pContext);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicepropertiesbulk-queuesetvaluesbyobjectlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueueSetValuesByObjectList([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValuesCollection>))] IPortableDeviceValuesCollection pObjectValues, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropertiesBulkCallback>))] IPortableDevicePropertiesBulkCallback pCallback, out Guid pContext);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicepropertiesbulk-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(in Guid pContext);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicepropertiesbulk-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel(in Guid pContext);
}
