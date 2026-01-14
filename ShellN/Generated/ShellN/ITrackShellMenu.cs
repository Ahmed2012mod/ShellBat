#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/nn-shdeprecated-itrackshellmenu
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8278f932-2a3e-11d2-838f-00c04fd918d0")]
public partial interface ITrackShellMenu : IShellMenu
{
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itrackshellmenu-setobscured
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObscured(HWND hwndTB, nint punkBand, uint dwSMSetFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itrackshellmenu-popup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Popup(HWND hwnd, ref POINTL ppt, ref RECTL prcExclude, int dwFlags);
}
