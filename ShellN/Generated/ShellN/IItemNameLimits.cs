#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iitemnamelimits
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1df0d7f1-b267-4d28-8b10-12e23202a5c4")]
public partial interface IItemNameLimits
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iitemnamelimits-getvalidcharacters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValidCharacters(out PWSTR ppwszValidChars, out PWSTR ppwszInvalidChars);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iitemnamelimits-getmaxlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxLength(PWSTR pszName, out int piMaxNameLen);
}
