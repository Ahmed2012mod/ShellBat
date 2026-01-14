#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-idelayedpropertystorefactory
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("40d4577f-e237-4bdb-bd69-58f089431b6a")]
public partial interface IDelayedPropertyStoreFactory : IPropertyStoreFactory
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-idelayedpropertystorefactory-getdelayedpropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDelayedPropertyStore(GETPROPERTYSTOREFLAGS flags, uint dwStoreId, in Guid riid, out nint /* void */ ppv);
}
