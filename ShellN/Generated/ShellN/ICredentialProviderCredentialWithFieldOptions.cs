#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialprovidercredentialwithfieldoptions
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("dbc6fb30-c843-49e3-a645-573e6f39446a")]
public partial interface ICredentialProviderCredentialWithFieldOptions
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredentialwithfieldoptions-getfieldoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFieldOptions(uint fieldID, out CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS options);
}
