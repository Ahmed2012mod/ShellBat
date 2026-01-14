#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-iconnectablecredentialprovidercredential
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("9387928b-ac75-4bf9-8ab2-2b93c4a55290")]
public partial interface IConnectableCredentialProviderCredential : ICredentialProviderCredential
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-iconnectablecredentialprovidercredential-connect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Connect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IQueryContinueWithStatus>))] IQueryContinueWithStatus pqcws);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-iconnectablecredentialprovidercredential-disconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disconnect();
}
