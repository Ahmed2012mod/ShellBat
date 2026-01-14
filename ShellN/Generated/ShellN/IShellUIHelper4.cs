#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("b36e6a53-8073-499e-824c-d776330a333e")]
public partial interface IShellUIHelper4 : IShellUIHelper3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msIsSiteMode(out VARIANT_BOOL pfSiteMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeShowThumbBar();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeAddThumbBarButton(BSTR bstrIconURL, BSTR bstrTooltip, out VARIANT pvarButtonID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeUpdateThumbBarButton(VARIANT ButtonID, VARIANT_BOOL fEnabled, VARIANT_BOOL fVisible);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeSetIconOverlay(BSTR IconUrl, in VARIANT pvarDescription);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeClearIconOverlay();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msAddSiteMode();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeCreateJumpList(BSTR bstrHeader);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeAddJumpListItem(BSTR bstrName, BSTR bstrActionUri, BSTR bstrIconUri, in VARIANT pvarWindowType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeClearJumpList();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeShowJumpList();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeAddButtonStyle(VARIANT uiButtonID, BSTR bstrIconUrl, BSTR bstrTooltip, out VARIANT pvarStyleID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeShowButtonStyle(VARIANT uiButtonID, VARIANT uiStyleID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msSiteModeActivate();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msIsSiteModeFirstRun(VARIANT_BOOL fPreserveState, out VARIANT puiFirstRun);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msAddTrackingProtectionList(BSTR URL, BSTR bstrFilterName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msTrackingProtectionEnabled(out VARIANT_BOOL pfEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT msActiveXFilteringEnabled(out VARIANT_BOOL pfEnabled);
}
