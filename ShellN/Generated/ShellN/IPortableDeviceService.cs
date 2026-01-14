#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledeviceservice
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("d3bd3a44-d7b5-40a9-98b7-2fa4d01dec08")]
public partial interface IPortableDeviceService
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(PWSTR pszPnPServiceID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pClientInfo);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-capabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Capabilities([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceServiceCapabilities>))] out IPortableDeviceServiceCapabilities ppCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-content
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Content([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceContent2>))] out IPortableDeviceContent2 ppContent);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-methods
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Methods([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceServiceMethods>))] out IPortableDeviceServiceMethods ppMethods);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-getserviceobjectid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceObjectID(out PWSTR ppszServiceObjectID);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-getpnpserviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPnPServiceID(out PWSTR ppszPnPServiceID);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceEventCallback>))] IPortableDeviceEventCallback pCallback, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pParameters, out PWSTR ppszCookie);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(PWSTR pszCookie);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservice-sendcommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendCommand(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pParameters, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppResults);
}
