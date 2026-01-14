#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialprovidersetuserarray
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("095c1484-1c0c-4388-9c6d-500e61bf84bd")]
public partial interface ICredentialProviderSetUserArray
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovidersetuserarray-setuserarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUserArray([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderUserArray>))] ICredentialProviderUserArray users);
}
