#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertystorecache
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("3017056d-9a91-4e90-937d-746c72abbf4f")]
public partial interface IPropertyStoreCache : IPropertyStore
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystorecache-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(in PROPERTYKEY key, out PSC_STATE pstate);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystorecache-getvalueandstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueAndState(in PROPERTYKEY key, out PROPVARIANT ppropvar, out PSC_STATE pstate);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetState(in PROPERTYKEY key, PSC_STATE state);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystorecache-setvalueandstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValueAndState(in PROPERTYKEY key, in PROPVARIANT ppropvar, PSC_STATE state);
}
