#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/nn-shlobj-icopyhooka
[GeneratedComInterface, Guid("000214ef-0000-0000-c000-000000000046")]
public partial interface ICopyHookA
{
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-icopyhooka-copycallback
    [PreserveSig]
    uint CopyCallback(HWND hwnd, uint wFunc, uint wFlags, PSTR pszSrcFile, uint dwSrcAttribs, PSTR pszDestFile, uint dwDestAttribs);
}
