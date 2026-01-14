#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-iobjectwithpropertykey
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fc0ca0a7-c316-4fd2-9031-3e628e6d4f23")]
public partial interface IObjectWithPropertyKey
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-iobjectwithpropertykey-setpropertykey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPropertyKey(in PROPERTYKEY key);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-iobjectwithpropertykey-getpropertykey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyKey(out PROPERTYKEY pkey);
}
