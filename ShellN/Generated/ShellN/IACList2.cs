#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-iaclist2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("470141a0-5186-11d2-bbb6-0060977b464c")]
public partial interface IACList2 : IACList
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iaclist2-setoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOptions(uint dwFlag);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iaclist2-getoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOptions(out uint pdwFlag);
}
