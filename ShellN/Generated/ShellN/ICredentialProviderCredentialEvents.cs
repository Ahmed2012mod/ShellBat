#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialprovidercredentialevents
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fa6fa76b-66b7-4b11-95f1-86171118e816")]
public partial interface ICredentialProviderCredentialEvents
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents-setfieldstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFieldState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] ICredentialProviderCredential pcpc, uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_STATE cpfs);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents-setfieldinteractivestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFieldInteractiveState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] ICredentialProviderCredential pcpc, uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE cpfis);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents-setfieldstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFieldString([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] ICredentialProviderCredential pcpc, uint dwFieldID, PWSTR psz);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents-setfieldcheckbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFieldCheckbox([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] ICredentialProviderCredential pcpc, uint dwFieldID, BOOL bChecked, PWSTR pszLabel);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents-setfieldbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFieldBitmap([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] ICredentialProviderCredential pcpc, uint dwFieldID, HBITMAP hbmp);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents-setfieldcomboboxselecteditem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFieldComboBoxSelectedItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] ICredentialProviderCredential pcpc, uint dwFieldID, uint dwSelectedItem);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents-deletefieldcomboboxitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteFieldComboBoxItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] ICredentialProviderCredential pcpc, uint dwFieldID, uint dwItem);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents-appendfieldcomboboxitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendFieldComboBoxItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] ICredentialProviderCredential pcpc, uint dwFieldID, PWSTR pszItem);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents-setfieldsubmitbutton
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFieldSubmitButton([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] ICredentialProviderCredential pcpc, uint dwFieldID, uint dwAdjacentTo);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents-oncreatingwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnCreatingWindow(out HWND phwndOwner);
}
