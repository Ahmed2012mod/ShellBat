#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/nn-shlobj-icopyhookw
[GeneratedComInterface, Guid("000214fc-0000-0000-c000-000000000046")]
public partial interface ICopyHookW
{
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-icopyhookw-copycallback
    [PreserveSig]
    uint CopyCallback(HWND hwnd, uint wFunc, uint wFlags, PWSTR pszSrcFile, uint dwSrcAttribs, PWSTR pszDestFile, uint dwDestAttribs);
}
