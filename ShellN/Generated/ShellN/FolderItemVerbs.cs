#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/folderitemverbs
[GeneratedComInterface, Guid("1f8352c0-50b0-11cf-960c-0080c7f4ee85")]
public partial interface FolderItemVerbs : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int plCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Application([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Parent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    // https://learn.microsoft.com/windows/win32/shell/folderitemverbs-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(VARIANT index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItemVerb>))] out FolderItemVerb ppid);
    
    // https://learn.microsoft.com/windows/win32/shell/folderitemverbs--newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT _NewEnum(out nint ppunk);
}
