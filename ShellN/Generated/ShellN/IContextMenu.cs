#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icontextmenu
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214e4-0000-0000-c000-000000000046")]
public partial interface IContextMenu
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icontextmenu-querycontextmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryContextMenu(HMENU hmenu, uint indexMenu, uint idCmdFirst, uint idCmdLast, uint uFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icontextmenu-invokecommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeCommand(in CMINVOKECOMMANDINFO pici);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icontextmenu-getcommandstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCommandString(nuint idCmd, uint uType, nint /* optional uint* */ pReserved, nint pszName, uint cchMax);
}
