#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialprovidercredentialevents2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("b53c00b6-9922-4b78-b1f4-ddfe774dc39b")]
public partial interface ICredentialProviderCredentialEvents2 : ICredentialProviderCredentialEvents
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents2-beginfieldupdates
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginFieldUpdates();
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents2-endfieldupdates
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndFieldUpdates();
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialevents2-setfieldoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFieldOptions([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] ICredentialProviderCredential credential, uint fieldID, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS options);
}
