#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/folder2-object
[GeneratedComInterface, Guid("f0d2d8ef-3890-11d2-bf8b-00c04fb93661")]
public partial interface Folder2 : Folder
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Self([MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItem>))] out FolderItem ppfi);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OfflineStatus(out int pul);
    
    // https://learn.microsoft.com/windows/win32/shell/folder2-synchronize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Synchronize();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HaveToShowWebViewBarricade(out VARIANT_BOOL pbHaveToShowWebViewBarricade);
    
    // https://learn.microsoft.com/windows/win32/shell/folder2-dismissedwebviewbarricade
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DismissedWebViewBarricade();
}
