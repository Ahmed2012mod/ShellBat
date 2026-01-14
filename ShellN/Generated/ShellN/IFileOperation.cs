#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifileoperation
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("947aab5f-0a5c-4c13-b4d6-4bf7836fc9f8")]
public partial interface IFileOperation
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperationProgressSink>))] IFileOperationProgressSink pfops, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-setoperationflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOperationFlags(FILEOPERATION_FLAGS dwOperationFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-setprogressmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProgressMessage(PWSTR pszMessage);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-setprogressdialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProgressDialog([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOperationsProgressDialog>))] IOperationsProgressDialog popd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-setproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperties([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyChangeArray>))] IPropertyChangeArray pproparray);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-setownerwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOwnerWindow(HWND hwndOwner);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-applypropertiestoitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ApplyPropertiesToItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-applypropertiestoitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ApplyPropertiesToItems(nint punkItems);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-renameitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenameItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, PWSTR pszNewName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperationProgressSink>))] IFileOperationProgressSink pfopsItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-renameitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenameItems(nint pUnkItems, PWSTR pszNewName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-moveitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder, PWSTR pszNewName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperationProgressSink>))] IFileOperationProgressSink pfopsItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-moveitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveItems(nint punkItems, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-copyitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder, PWSTR pszCopyName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperationProgressSink>))] IFileOperationProgressSink pfopsItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-copyitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyItems(nint punkItems, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-deleteitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperationProgressSink>))] IFileOperationProgressSink pfopsItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-deleteitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteItems(nint punkItems);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-newitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NewItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder, uint dwFileAttributes, PWSTR pszName, PWSTR pszTemplateName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperationProgressSink>))] IFileOperationProgressSink pfopsItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-performoperations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PerformOperations();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperation-getanyoperationsaborted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAnyOperationsAborted(out BOOL pfAnyOperationsAborted);
}
