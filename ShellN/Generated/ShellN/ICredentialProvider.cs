#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialprovider
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d27c3481-5a1c-45b2-8aaa-c20ebbe8229e")]
public partial interface ICredentialProvider
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovider-setusagescenario
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUsageScenario(CREDENTIAL_PROVIDER_USAGE_SCENARIO cpus, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovider-setserialization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSerialization(in CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION pcpcs);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovider-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderEvents>))] ICredentialProviderEvents pcpe, nuint upAdviseContext);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovider-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnAdvise();
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovider-getfielddescriptorcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFieldDescriptorCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovider-getfielddescriptorat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFieldDescriptorAt(uint dwIndex, out nint ppcpfd);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovider-getcredentialcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCredentialCount(out uint pdwCount, out uint pdwDefault, out BOOL pbAutoLogonWithDefault);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovider-getcredentialat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCredentialAt(uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICredentialProviderCredential>))] out ICredentialProviderCredential ppcpc);
}
