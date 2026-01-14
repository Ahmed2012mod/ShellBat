#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledevice
[GeneratedComInterface, Guid("625e2df8-6392-4cf0-9ad1-3cfa5f17775c")]
public partial interface IPortableDevice
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevice-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(PWSTR pszPnPDeviceID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pClientInfo);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevice-sendcommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendCommand(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pParameters, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppResults);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevice-content
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Content([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceContent>))] out IPortableDeviceContent ppContent);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevice-capabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Capabilities([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceCapabilities>))] out IPortableDeviceCapabilities ppCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevice-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevice-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevice-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceEventCallback>))] IPortableDeviceEventCallback pCallback, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pParameters, out PWSTR ppszCookie);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevice-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(PWSTR pszCookie);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevice-getpnpdeviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPnPDeviceID(out PWSTR ppszPnPDeviceID);
}
