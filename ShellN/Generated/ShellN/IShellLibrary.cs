#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishelllibrary
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("11a66efa-382e-451a-9234-1e0e12ef3085")]
public partial interface IShellLibrary
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-loadlibraryfromitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadLibraryFromItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiLibrary, uint grfMode);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-loadlibraryfromknownfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadLibraryFromKnownFolder(in Guid kfidLibrary, uint grfMode);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-addfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiLocation);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-removefolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiLocation);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-getfolders
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolders(LIBRARYFOLDERFILTER lff, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-resolvefolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResolveFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiFolderToResolve, uint dwTimeout, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-getdefaultsavefolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultSaveFolder(DEFAULTSAVEFOLDERTYPE dsft, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-setdefaultsavefolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultSaveFolder(DEFAULTSAVEFOLDERTYPE dsft, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-getoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOptions(out LIBRARYOPTIONFLAGS plofOptions);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-setoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOptions(LIBRARYOPTIONFLAGS lofMask, LIBRARYOPTIONFLAGS lofOptions);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-getfoldertype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolderType(out Guid pftid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-setfoldertype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFolderType(in Guid ftid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-geticon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIcon(out PWSTR ppszIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-seticon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIcon(PWSTR pszIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-save
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiFolderToSaveIn, PWSTR pszLibraryName, LIBRARYSAVEFLAGS lsf, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem ppsiSavedTo);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllibrary-saveinknownfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveInKnownFolder(in Guid kfidToSaveIn, PWSTR pszLibraryName, LIBRARYSAVEFLAGS lsf, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem ppsiSavedTo);
}
