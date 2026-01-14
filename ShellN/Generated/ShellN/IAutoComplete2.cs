#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shldisp/nn-shldisp-iautocomplete2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("eac04bc0-3791-11d2-bb95-0060977b464c")]
public partial interface IAutoComplete2 : IAutoComplete
{
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-iautocomplete2-setoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOptions(uint dwFlag);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-iautocomplete2-getoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOptions(out uint pdwFlag);
}
