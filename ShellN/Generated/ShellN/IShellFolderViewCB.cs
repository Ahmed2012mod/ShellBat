#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-ishellfolderviewcb
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("2047e320-f2a9-11ce-ae65-08002b2e1262")]
public partial interface IShellFolderViewCB
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishellfolderviewcb-messagesfvcb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MessageSFVCB(uint uMsg, WPARAM wParam, LPARAM lParam);
}
