#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("5efb46d7-47c0-4b68-acda-ded47c90ec91")]
public partial interface IStorageProviderBanners
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBanner(PWSTR providerIdentity, PWSTR subscriptionId, PWSTR contentId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearBanner(PWSTR providerIdentity, PWSTR subscriptionId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearAllBanners(PWSTR providerIdentity);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBanner(PWSTR providerIdentity, PWSTR subscriptionId, out PWSTR contentId);
}
