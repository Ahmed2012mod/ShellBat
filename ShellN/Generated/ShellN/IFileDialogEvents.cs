#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifiledialogevents
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("973510db-7d7f-452b-8975-74a85828d354")]
public partial interface IFileDialogEvents
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogevents-onfileok
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnFileOk([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialog>))] IFileDialog pfd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogevents-onfolderchanging
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnFolderChanging([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialog>))] IFileDialog pfd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiFolder);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogevents-onfolderchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnFolderChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialog>))] IFileDialog pfd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogevents-onselectionchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSelectionChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialog>))] IFileDialog pfd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogevents-onshareviolation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnShareViolation([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialog>))] IFileDialog pfd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, out FDE_SHAREVIOLATION_RESPONSE pResponse);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogevents-ontypechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTypeChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialog>))] IFileDialog pfd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialogevents-onoverwrite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnOverwrite([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialog>))] IFileDialog pfd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, out FDE_OVERWRITE_RESPONSE pResponse);
}
