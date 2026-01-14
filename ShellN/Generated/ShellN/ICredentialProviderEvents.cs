#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialproviderevents
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("34201e5a-a787-41a3-a5a4-bd6dcf2a854e")]
public partial interface ICredentialProviderEvents
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialproviderevents-credentialschanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CredentialsChanged(nuint upAdviseContext);
}
