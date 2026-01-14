#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifileoperationprogresssink
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("04b0f1a7-9490-44bc-96e1-4296a31252e2")]
public partial interface IFileOperationProgressSink
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-startoperations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartOperations();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-finishoperations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FinishOperations(HRESULT hrResult);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-prerenameitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreRenameItem(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, PWSTR pszNewName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postrenameitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostRenameItem(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, PWSTR pszNewName, HRESULT hrRename, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiNewlyCreated);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-premoveitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreMoveItem(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder, PWSTR pszNewName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postmoveitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostMoveItem(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder, PWSTR pszNewName, HRESULT hrMove, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiNewlyCreated);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-precopyitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreCopyItem(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder, PWSTR pszNewName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postcopyitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostCopyItem(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder, PWSTR pszNewName, HRESULT hrCopy, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiNewlyCreated);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-predeleteitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreDeleteItem(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postdeleteitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostDeleteItem(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem, HRESULT hrDelete, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiNewlyCreated);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-prenewitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreNewItem(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder, PWSTR pszNewName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-postnewitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostNewItem(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiDestinationFolder, PWSTR pszNewName, PWSTR pszTemplateName, uint dwFileAttributes, HRESULT hrNew, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiNewItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-updateprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateProgress(uint iWorkTotal, uint iWorkSoFar);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-resettimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetTimer();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-pausetimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PauseTimer();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifileoperationprogresssink-resumetimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResumeTimer();
}
