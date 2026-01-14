#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icontextmenusite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0811aebe-0b87-4c54-9e72-548cf649016b")]
public partial interface IContextMenuSite
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icontextmenusite-docontextmenupopup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoContextMenuPopup(nint punkContextMenu, uint fFlags, POINT pt);
}
