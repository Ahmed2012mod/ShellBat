#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iparseandcreateitem
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("67efed0e-e827-4408-b493-78f3982b685c")]
public partial interface IParseAndCreateItem
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iparseandcreateitem-setitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iparseandcreateitem-getitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItem(in Guid riid, out nint /* void */ ppv);
}
