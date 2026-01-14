#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("a2a08b09-103d-4d3f-b91c-ea455ca82efa")]
public partial interface IShellUIHelper5 : IShellUIHelper4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msProvisionNetworks(BSTR bstrProvisioningXml, out VARIANT puiResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msReportSafeUrl();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeRefreshBadge();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeClearBadge();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msDiagnoseConnectionUILess();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msLaunchNetworkClientHelp();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msChangeDefaultBrowser(VARIANT_BOOL fChange);
}
