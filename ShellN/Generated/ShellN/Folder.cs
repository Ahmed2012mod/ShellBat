#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/folder
[GeneratedComInterface, Guid("bbcbde60-c3ff-11ce-8350-444553540000")]
public partial interface Folder : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Title(out BSTR pbs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Application([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Parent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ParentFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<Folder>))] out Folder ppsf);
    
    // https://learn.microsoft.com/windows/win32/shell/folder-items
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Items([MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItems>))] out FolderItems ppid);
    
    // https://learn.microsoft.com/windows/win32/shell/folder-parsename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseName(BSTR bName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItem>))] out FolderItem ppid);
    
    // https://learn.microsoft.com/windows/win32/shell/folder-newfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NewFolder(BSTR bName, VARIANT vOptions);
    
    // https://learn.microsoft.com/windows/win32/shell/folder-movehere
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveHere(VARIANT vItem, VARIANT vOptions);
    
    // https://learn.microsoft.com/windows/win32/shell/folder-copyhere
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyHere(VARIANT vItem, VARIANT vOptions);
    
    // https://learn.microsoft.com/windows/win32/shell/folder-getdetailsof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDetailsOf(VARIANT vItem, int iColumn, out BSTR pbs);
}
