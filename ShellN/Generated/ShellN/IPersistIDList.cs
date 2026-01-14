#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ipersistidlist
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1079acfc-29bd-11d3-8e0d-00c04f6837d5")]
public partial interface IPersistIDList : IPersist
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipersistidlist-setidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIDList(nint pidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipersistidlist-getidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIDList(out nint ppidl);
}
