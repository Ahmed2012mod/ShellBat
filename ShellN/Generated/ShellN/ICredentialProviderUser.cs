#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/nn-credentialprovider-icredentialprovideruser
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("13793285-3ea6-40fd-b420-15f47da41fbb")]
public partial interface ICredentialProviderUser
{
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovideruser-getsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSid(out PWSTR sid);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovideruser-getproviderid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProviderID(out Guid providerID);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovideruser-getstringvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringValue(in PROPERTYKEY key, out PWSTR stringValue);
    
    // https://learn.microsoft.com/windows/win32/api/credentialprovider/nf-credentialprovider-icredentialprovideruser-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(in PROPERTYKEY key, out PROPVARIANT value);
}
