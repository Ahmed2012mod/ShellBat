#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-irelateditem
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a73ce67a-8ab1-44f1-8d43-d2fcbf6b1cd0")]
public partial interface IRelatedItem
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-irelateditem-getitemidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemIDList(out nint ppidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-irelateditem-getitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem ppsi);
}
