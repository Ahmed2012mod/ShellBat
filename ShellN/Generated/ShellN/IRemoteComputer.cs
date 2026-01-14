#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iremotecomputer
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("000214fe-0000-0000-c000-000000000046")]
public partial interface IRemoteComputer
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iremotecomputer-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(PWSTR pszMachine, BOOL bEnumerating);
}
