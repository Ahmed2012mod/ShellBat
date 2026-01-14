#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iinsertitem
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("d2b57227-3d23-4b95-93c0-492bd454c356")]
public partial interface IInsertItem
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iinsertitem-insertitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertItem(nint pidl);
}
