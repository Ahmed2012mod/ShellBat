#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shldisp/nn-shldisp-ishellfolderviewdual
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("e7a1af80-4d96-11cf-960c-0080c7f4ee85")]
public partial interface IShellFolderViewDual : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual-get_application
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Application([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual-get_parent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Parent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual-get_folder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Folder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<Folder>))] out Folder ppid);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual-selecteditems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectedItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItems>))] out FolderItems ppid);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual-get_focuseditem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FocusedItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItem>))] out FolderItem ppid);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual-selectitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectItem(in VARIANT pvfi, int dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual-popupitemmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PopupItemMenu([MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItem>))] FolderItem pfi, VARIANT vx, VARIANT vy, out BSTR pbs);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual-get_script
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Script([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppDisp);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual-get_viewoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ViewOptions(out int plViewOptions);
}
