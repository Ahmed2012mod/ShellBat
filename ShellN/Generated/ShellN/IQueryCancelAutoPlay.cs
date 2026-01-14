#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iquerycancelautoplay
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ddefe873-6997-4e68-be26-39b633adbe12")]
public partial interface IQueryCancelAutoPlay
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iquerycancelautoplay-allowautoplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllowAutoPlay(PWSTR pszPath, uint dwContentType, PWSTR pszLabel, uint dwSerialNumber);
}
