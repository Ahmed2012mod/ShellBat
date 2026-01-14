#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-iaclist
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("77a130b0-94fd-11d0-a544-00c04fd7d062")]
public partial interface IACList
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iaclist-expand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Expand(PWSTR pszExpand);
}
