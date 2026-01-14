#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledeviceeventcallback
[GeneratedComInterface, Guid("a8792a31-f385-493c-a893-40f64eb45f6e")]
public partial interface IPortableDeviceEventCallback
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceeventcallback-onevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnEvent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pEventParameters);
}
