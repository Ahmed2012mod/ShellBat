#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialprovidercredential
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("63913a93-40c1-481a-818d-4072ff8c70cc")]
public partial interface ICredentialProviderCredential
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredentialEvents>))] ICredentialProviderCredentialEvents pcpce);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnAdvise();
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-setselected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSelected(out BOOL pbAutoLogon);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-setdeselected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeselected();
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-getfieldstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFieldState(uint dwFieldID, out CREDENTIAL_PROVIDER_FIELD_STATE pcpfs, out CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE pcpfis);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-getstringvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringValue(uint dwFieldID, out PWSTR ppsz);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-getbitmapvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBitmapValue(uint dwFieldID, out HBITMAP phbmp);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-getcheckboxvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCheckboxValue(uint dwFieldID, out BOOL pbChecked, out PWSTR ppszLabel);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-getsubmitbuttonvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubmitButtonValue(uint dwFieldID, out uint pdwAdjacentTo);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-getcomboboxvaluecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComboBoxValueCount(uint dwFieldID, out uint pcItems, out uint pdwSelectedItem);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-getcomboboxvalueat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComboBoxValueAt(uint dwFieldID, uint dwItem, out PWSTR ppszItem);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-setstringvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStringValue(uint dwFieldID, PWSTR psz);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-setcheckboxvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCheckboxValue(uint dwFieldID, BOOL bChecked);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-setcomboboxselectedvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetComboBoxSelectedValue(uint dwFieldID, uint dwSelectedItem);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-commandlinkclicked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommandLinkClicked(uint dwFieldID);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-getserialization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSerialization(out CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE pcpgsr, out CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION pcpcs, out PWSTR ppszOptionalStatusText, out CREDENTIAL_PROVIDER_STATUS_ICON pcpsiOptionalStatusIcon);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential-reportresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReportResult(NTSTATUS ntsStatus, NTSTATUS ntsSubstatus, out PWSTR ppszOptionalStatusText, out CREDENTIAL_PROVIDER_STATUS_ICON pcpsiOptionalStatusIcon);
}
