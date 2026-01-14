#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialproviderfilter
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a5da53f9-d475-4080-a120-910c4a739880")]
public partial interface ICredentialProviderFilter
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialproviderfilter-filter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Filter(CREDENTIAL_PROVIDER_USAGE_SCENARIO cpus, uint dwFlags, [In][MarshalUsing(CountElementName = nameof(cProviders))] Guid[] rgclsidProviders, [In][Out][MarshalUsing(CountElementName = nameof(cProviders))] BOOL[] rgbAllow, uint cProviders);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialproviderfilter-updateremotecredential
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateRemoteCredential(in CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION pcpcsIn, out CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION pcpcsOut);
}
