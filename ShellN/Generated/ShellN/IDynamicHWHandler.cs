#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-idynamichwhandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("dc2601d7-059e-42fc-a09d-2afd21b6d5f7")]
public partial interface IDynamicHWHandler
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-idynamichwhandler-getdynamicinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDynamicInfo(PWSTR pszDeviceID, uint dwContentType, out PWSTR ppszAction);
}
