#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifilesavedialog
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("84bccd23-5fde-4cdb-aea4-af64b83d78ab")]
public partial interface IFileSaveDialog : IFileDialog
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesavedialog-setsaveasitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSaveAsItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesavedialog-setproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperties([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pStore);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesavedialog-setcollectedproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCollectedProperties([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyDescriptionList>))] IPropertyDescriptionList pList, BOOL fAppendDefault);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesavedialog-getproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperties([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] out IPropertyStore ppStore);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesavedialog-applyproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ApplyProperties([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pStore, HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileOperationProgressSink>))] IFileOperationProgressSink pSink);
}
