#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledevicemanager
[GeneratedComInterface, Guid("a1567595-4c2f-4574-a6fa-ecef917b9a40")]
public partial interface IPortableDeviceManager
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicemanager-getdevices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevices(nint pPnPDeviceIDs, ref uint pcPnPDeviceIDs);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicemanager-refreshdevicelist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RefreshDeviceList();
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicemanager-getdevicefriendlyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceFriendlyName(PWSTR pszPnPDeviceID, PWSTR pDeviceFriendlyName, ref uint pcchDeviceFriendlyName);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicemanager-getdevicedescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceDescription(PWSTR pszPnPDeviceID, PWSTR pDeviceDescription, ref uint pcchDeviceDescription);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicemanager-getdevicemanufacturer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceManufacturer(PWSTR pszPnPDeviceID, PWSTR pDeviceManufacturer, ref uint pcchDeviceManufacturer);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicemanager-getdeviceproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceProperty(PWSTR pszPnPDeviceID, PWSTR pszDevicePropertyName, nint /* byte array */ pData, ref uint pcbData, ref uint pdwType);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicemanager-getprivatedevices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateDevices(nint pPnPDeviceIDs, ref uint pcPnPDeviceIDs);
}
