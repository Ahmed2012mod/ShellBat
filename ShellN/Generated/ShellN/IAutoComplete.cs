#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shldisp/nn-shldisp-iautocomplete
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00bb2762-6a77-11d0-a535-00c04fd7d062")]
public partial interface IAutoComplete
{
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-iautocomplete-init
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Init(HWND hwndEdit, nint punkACL, PWSTR pwszRegKeyPath, PWSTR pwszQuickComplete);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-iautocomplete-enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enable(BOOL fEnable);
}
