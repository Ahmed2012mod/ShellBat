#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertystorecapabilities
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("c8e2d566-186e-4d49-bf41-6909ead56acc")]
public partial interface IPropertyStoreCapabilities
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertystorecapabilities-ispropertywritable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsPropertyWritable(in PROPERTYKEY key);
}
