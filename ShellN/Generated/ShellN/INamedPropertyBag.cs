#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-inamedpropertybag
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("fb700430-952c-11d1-946f-000000000000")]
public partial interface INamedPropertyBag
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-inamedpropertybag-readpropertynpb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadPropertyNPB(PWSTR pszBagname, PWSTR pszPropName, ref PROPVARIANT pVar);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-inamedpropertybag-writepropertynpb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WritePropertyNPB(PWSTR pszBagname, PWSTR pszPropName, in PROPVARIANT pVar);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-inamedpropertybag-removepropertynpb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemovePropertyNPB(PWSTR pszBagname, PWSTR pszPropName);
}
