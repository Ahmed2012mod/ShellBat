#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-inamespacewalkcb
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("d92995f8-cf5e-4a76-bf59-ead39ea2b97e")]
public partial interface INamespaceWalkCB
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacewalkcb-founditem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FoundItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolder>))] IShellFolder psf, nint pidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacewalkcb-enterfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnterFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolder>))] IShellFolder psf, nint pidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacewalkcb-leavefolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LeaveFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolder>))] IShellFolder psf, nint pidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacewalkcb-initializeprogressdialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeProgressDialog(out PWSTR ppszTitle, out PWSTR ppszCancel);
}
