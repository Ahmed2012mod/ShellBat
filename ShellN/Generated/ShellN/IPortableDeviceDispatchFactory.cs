#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledevicedispatchfactory
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5e1eafc3-e3d7-4132-96fa-759c0f9d1e0f")]
public partial interface IPortableDeviceDispatchFactory
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicedispatchfactory-getdevicedispatch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceDispatch(PWSTR pszPnPDeviceID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppDeviceDispatch);
}
