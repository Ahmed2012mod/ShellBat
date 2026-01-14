#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/folderitem
[GeneratedComInterface, Guid("fac32c80-cbe4-11ce-8350-444553540000")]
public partial interface FolderItem : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Application([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Parent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR pbs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Name(BSTR bs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Path(out BSTR pbs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_GetLink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_GetFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsLink(out VARIANT_BOOL pb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsFolder(out VARIANT_BOOL pb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsFileSystem(out VARIANT_BOOL pb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsBrowsable(out VARIANT_BOOL pb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ModifyDate(out double pdt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ModifyDate(double dt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Size(out int pul);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(out BSTR pbs);
    
    // https://learn.microsoft.com/windows/win32/shell/folderitem-verbs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Verbs([MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItemVerbs>))] out FolderItemVerbs ppfic);
    
    // https://learn.microsoft.com/windows/win32/shell/folderitem-invokeverb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeVerb(VARIANT vVerb);
}
