#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-iqueryinfo
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00021500-0000-0000-c000-000000000046")]
public partial interface IQueryInfo
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iqueryinfo-getinfotip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInfoTip(uint dwFlags, out PWSTR ppwszTip);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iqueryinfo-getinfoflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInfoFlags(out uint pdwFlags);
}
