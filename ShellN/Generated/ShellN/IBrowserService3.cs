#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/nn-shdeprecated-ibrowserservice3
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("27d7ce21-762d-48f3-86f3-40e2fd3749c4")]
public partial interface IBrowserService3 : IBrowserService2
{
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice3-_positionviewwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT _PositionViewWindow(HWND hwnd, in RECT prc);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice3-ieparsedisplaynameex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IEParseDisplayNameEx(uint uiCP, PWSTR pwszPath, uint dwFlags, out nint ppidlOut);
}
