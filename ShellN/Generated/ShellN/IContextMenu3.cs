#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icontextmenu3
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("bcfce0a0-ec17-11d0-8d10-00a0c90f2719")]
public partial interface IContextMenu3 : IContextMenu2
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icontextmenu3-handlemenumsg2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HandleMenuMsg2(uint uMsg, WPARAM wParam, LPARAM lParam, nint /* optional LRESULT* */ plResult);
}
