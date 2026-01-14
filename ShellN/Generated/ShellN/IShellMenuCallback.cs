#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellmenucallback
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("4ca300a1-9b8d-11d1-8b22-00c04fd918d0")]
public partial interface IShellMenuCallback
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellmenucallback-callbacksm
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CallbackSM(ref SMDATA psmd, uint uMsg, WPARAM wParam, LPARAM lParam);
}
