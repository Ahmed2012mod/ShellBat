#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialprovidercredential2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("fd672c54-40ea-4d6e-9b49-cfb1a7507bd7")]
public partial interface ICredentialProviderCredential2 : ICredentialProviderCredential
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidercredential2-getusersid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserSid(out PWSTR sid);
}
