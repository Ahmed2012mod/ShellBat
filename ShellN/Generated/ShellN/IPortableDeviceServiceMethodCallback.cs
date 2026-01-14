#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledeviceservicemethodcallback
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c424233c-afce-4828-a756-7ed7a2350083")]
public partial interface IPortableDeviceServiceMethodCallback
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicemethodcallback-oncomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnComplete(HRESULT hrStatus, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pResults);
}
