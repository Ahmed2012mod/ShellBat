#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iinitializenetworkfolder
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6e0f9881-42a8-4f2a-97f8-8af4e026d92d")]
public partial interface IInitializeNetworkFolder
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iinitializenetworkfolder-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint pidl, nint pidlTarget, uint uDisplayType, PWSTR pszResName, PWSTR pszProvider);
}
