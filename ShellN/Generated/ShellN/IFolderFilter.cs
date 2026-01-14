#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifolderfilter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9cc22886-dc8e-11d2-b1d0-00c04f8eeb3e")]
public partial interface IFolderFilter
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderfilter-shouldshow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShouldShow([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolder>))] IShellFolder psf, nint pidlFolder, nint pidlItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderfilter-getenumflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumFlags([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolder>))] IShellFolder psf, nint pidlFolder, out HWND phwnd, ref uint pgrfFlags);
}
