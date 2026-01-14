#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ipreviousversionsinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("76e54780-ad74-48e3-a695-3ba9a0aff10d")]
public partial interface IPreviousVersionsInfo
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ipreviousversionsinfo-aresnapshotsavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AreSnapshotsAvailable(PWSTR pszPath, BOOL fOkToBeSlow, out BOOL pfAvailable);
}
