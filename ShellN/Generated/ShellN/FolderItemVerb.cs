#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/folderitemverb
[GeneratedComInterface, Guid("08ec3e00-50b0-11cf-960c-0080c7f4ee85")]
public partial interface FolderItemVerb : IDispatch
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
    
    // https://learn.microsoft.com/windows/win32/shell/folderitemverb-doit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoIt();
}
