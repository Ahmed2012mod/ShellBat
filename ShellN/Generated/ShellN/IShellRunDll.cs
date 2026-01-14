#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ishellrundll
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fce4bde0-4b68-4b80-8e9c-7426315a7388")]
public partial interface IShellRunDll
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ishellrundll-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run(PWSTR pszArgs);
}
