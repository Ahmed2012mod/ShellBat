#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledeviceservicemethods
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("e20333c9-fd34-412d-a381-cc6f2d820df7")]
public partial interface IPortableDeviceServiceMethods
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicemethods-invoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke(in Guid Method, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pParameters, ref IPortableDeviceValues ppResults);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicemethods-invokeasync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeAsync(in Guid Method, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pParameters, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceServiceMethodCallback>))] IPortableDeviceServiceMethodCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicemethods-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceServiceMethodCallback>))] IPortableDeviceServiceMethodCallback pCallback);
}
