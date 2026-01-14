#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledeviceservicemanager
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a8abc4e9-a84a-47a9-80b3-c5d9b172a961")]
public partial interface IPortableDeviceServiceManager
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicemanager-getdeviceservices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceServices(PWSTR pszPnPDeviceID, in Guid guidServiceCategory, out PWSTR pServices, ref uint pcServices);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicemanager-getdeviceforservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceForService(PWSTR pszPnPServiceID, out PWSTR ppszPnPDeviceID);
}
