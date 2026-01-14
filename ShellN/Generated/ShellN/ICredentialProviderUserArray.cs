#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialprovideruserarray
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("90c119ae-0f18-4520-a1f1-114366a40fe8")]
public partial interface ICredentialProviderUserArray
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovideruserarray-setproviderfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProviderFilter(in Guid guidProviderToFilterTo);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovideruserarray-getaccountoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAccountOptions(out CREDENTIAL_PROVIDER_ACCOUNT_OPTIONS credentialProviderAccountOptions);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovideruserarray-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint userCount);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovideruserarray-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint userIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderUser>))] out ICredentialProviderUser user);
}
