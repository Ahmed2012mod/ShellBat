#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertystorefactory
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("bc110b6d-57e8-4148-a9c6-91015ab2f3a5")]
public partial interface IPropertyStoreFactory
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystorefactory-getpropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyStore(GETPROPERTYSTOREFLAGS flags, nint pUnkFactory, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystorefactory-getpropertystoreforkeys
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyStoreForKeys(in PROPERTYKEY rgKeys, uint cKeys, GETPROPERTYSTOREFLAGS flags, in Guid riid, out nint /* void */ ppv);
}
