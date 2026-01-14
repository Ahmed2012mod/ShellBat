#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iregtreeitem
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("a9521922-0812-4d44-9ec3-7fd38c726f3d")]
public partial interface IRegTreeItem
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iregtreeitem-getcheckstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCheckState(out BOOL pbCheck);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iregtreeitem-setcheckstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCheckState(BOOL bCheck);
}
