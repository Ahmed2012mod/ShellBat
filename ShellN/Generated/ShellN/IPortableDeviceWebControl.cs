#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledevicewebcontrol
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("94fc7953-5ca1-483a-8aee-df52e7747d00")]
public partial interface IPortableDeviceWebControl : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicewebcontrol-getdevicefromid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceFromId(BSTR deviceId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicewebcontrol-getdevicefromidasync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceFromIdAsync(BSTR deviceId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch pCompletionHandler, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch?>))] IDispatch? pErrorHandler);
}
