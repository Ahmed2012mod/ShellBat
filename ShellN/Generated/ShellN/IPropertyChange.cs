#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertychange
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f917bc8a-1bba-4478-a245-1bde03eb9431")]
public partial interface IPropertyChange : IObjectWithPropertyKey
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertychange-applytopropvariant
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ApplyToPropVariant(in PROPVARIANT propvarIn, out PROPVARIANT ppropvarOut);
}
