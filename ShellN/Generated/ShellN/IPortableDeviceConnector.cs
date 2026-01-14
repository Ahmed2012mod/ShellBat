#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceconnectapi/nn-portabledeviceconnectapi-iportabledeviceconnector
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("625e2df8-6392-4cf0-9ad1-3cfa5f17775c")]
public partial interface IPortableDeviceConnector
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceconnectapi/nf-portabledeviceconnectapi-iportabledeviceconnector-connect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Connect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IConnectionRequestCallback>))] IConnectionRequestCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceconnectapi/nf-portabledeviceconnectapi-iportabledeviceconnector-disconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disconnect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IConnectionRequestCallback>))] IConnectionRequestCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceconnectapi/nf-portabledeviceconnectapi-iportabledeviceconnector-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IConnectionRequestCallback>))] IConnectionRequestCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceconnectapi/nf-portabledeviceconnectapi-iportabledeviceconnector-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(in DEVPROPKEY pPropertyKey, out DEVPROPTYPE pPropertyType, out nint /* byte array */ ppData, out uint pcbData);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceconnectapi/nf-portabledeviceconnectapi-iportabledeviceconnector-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(in DEVPROPKEY pPropertyKey, DEVPROPTYPE PropertyType, nint /* byte array */ pData, uint cbData);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceconnectapi/nf-portabledeviceconnectapi-iportabledeviceconnector-getpnpid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPnPID(out PWSTR ppwszPnPID);
}
