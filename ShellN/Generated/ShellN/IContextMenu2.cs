#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icontextmenu2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214f4-0000-0000-c000-000000000046")]
public partial interface IContextMenu2 : IContextMenu
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icontextmenu2-handlemenumsg
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HandleMenuMsg(uint uMsg, WPARAM wParam, LPARAM lParam);
}
