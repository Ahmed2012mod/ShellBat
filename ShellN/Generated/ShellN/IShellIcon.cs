#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellicon
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214e5-0000-0000-c000-000000000046")]
public partial interface IShellIcon
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellicon-geticonof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIconOf(nint pidl, uint flags, out int pIconIndex);
}
