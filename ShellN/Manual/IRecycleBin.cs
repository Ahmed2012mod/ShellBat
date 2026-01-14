namespace ShellN;

// note this is IID_IRecycleBinManager because IID_IRecycleBin (f964ad97-96f4-48ab-b444-e8588bc7c7b3) is not served
[GeneratedComInterface, Guid("5869092d-8af9-4a6c-ae84-1f03be2246cc")]
public partial interface IRecycleBin
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Compact();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileData(PWSTR path, out DELETEDITEM item);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemCount(out long count);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUsedSpace(out long usedSpace);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEmpty();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PurgeAll([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperation>))] IFileOperation fileOperation);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PurgeItems(PWSTR paths, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperation>))] IFileOperation fileOperation);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SuspendUpdating(BOOL suspend);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RecycleItem(PWSTR path, uint flags, ulong size, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem item);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestoreItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray items, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperation>))] IFileOperation fileOperation);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestoreItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem item, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperation>))] IFileOperation fileOperation);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRecycled(PWSTR path, out BOOL recycled);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumItems(uint flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumRecycleItems>))] out IEnumRecycleItems items);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WillRecycle(PWSTR path);
}
