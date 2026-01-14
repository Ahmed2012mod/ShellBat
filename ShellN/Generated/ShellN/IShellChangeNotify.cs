#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-ishellchangenotify
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("d82be2b1-5764-11d0-a96e-00c04fd705a2")]
public partial interface IShellChangeNotify
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellchangenotify-onchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnChange(int lEvent, nint /* optional nint* */ pidl1, nint /* optional nint* */ pidl2);
}
