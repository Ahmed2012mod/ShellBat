#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/folderitems
[GeneratedComInterface, Guid("744129e0-cbe5-11ce-8350-444553540000")]
public partial interface FolderItems : IDispatch
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
    
    // https://learn.microsoft.com/windows/win32/shell/folderitems-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(VARIANT index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItem>))] out FolderItem ppid);
    
    // https://learn.microsoft.com/windows/win32/shell/folderitems--newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT _NewEnum(out nint ppunk);
}
