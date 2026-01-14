#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-isharingconfigurationmanager
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b4cd448a-9c86-4466-9201-2e62105b87ae")]
public partial interface ISharingConfigurationManager
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isharingconfigurationmanager-createshare
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateShare(DEF_SHARE_ID dsid, SHARE_ROLE role);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isharingconfigurationmanager-deleteshare
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteShare(DEF_SHARE_ID dsid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isharingconfigurationmanager-shareexists
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShareExists(DEF_SHARE_ID dsid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isharingconfigurationmanager-getsharepermissions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSharePermissions(DEF_SHARE_ID dsid, out SHARE_ROLE pRole);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isharingconfigurationmanager-shareprinters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SharePrinters();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isharingconfigurationmanager-stopsharingprinters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopSharingPrinters();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isharingconfigurationmanager-areprintersshared
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ArePrintersShared();
}
