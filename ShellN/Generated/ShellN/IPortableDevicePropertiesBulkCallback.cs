#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledevicepropertiesbulkcallback
[GeneratedComInterface, Guid("9deacb80-11e8-40e3-a9f3-f557986a7845")]
public partial interface IPortableDevicePropertiesBulkCallback
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicepropertiesbulkcallback-onstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStart(in Guid pContext);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicepropertiesbulkcallback-onprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnProgress(in Guid pContext, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValuesCollection>))] IPortableDeviceValuesCollection pResults);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicepropertiesbulkcallback-onend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnEnd(in Guid pContext, HRESULT hrStatus);
}
