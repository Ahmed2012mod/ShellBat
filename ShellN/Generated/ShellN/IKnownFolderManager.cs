#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iknownfoldermanager
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8be2d872-86aa-4d47-b776-32cca40c7018")]
public partial interface IKnownFolderManager
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfoldermanager-folderidfromcsidl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderIdFromCsidl(int nCsidl, out Guid pfid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfoldermanager-folderidtocsidl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FolderIdToCsidl(in Guid rfid, out int pnCsidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfoldermanager-getfolderids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolderIds([MarshalUsing(CountElementName = nameof(pCount))] out Guid[] ppKFId, ref uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfoldermanager-getfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolder(in Guid rfid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IKnownFolder>))] out IKnownFolder ppkf);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfoldermanager-getfolderbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolderByName(PWSTR pszCanonicalName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IKnownFolder>))] out IKnownFolder ppkf);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfoldermanager-registerfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterFolder(in Guid rfid, in KNOWNFOLDER_DEFINITION pKFD);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfoldermanager-unregisterfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterFolder(in Guid rfid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfoldermanager-findfolderfrompath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindFolderFromPath(PWSTR pszPath, FFFP_MODE mode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IKnownFolder>))] out IKnownFolder ppkf);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfoldermanager-findfolderfromidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindFolderFromIDList(nint pidl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IKnownFolder>))] out IKnownFolder ppkf);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfoldermanager-redirect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Redirect(in Guid rfid, HWND hwnd, uint flags, PWSTR pszTargetPath, uint cFolders, nint /* optional Guid* */ pExclusion, nint /* optional PWSTR* */ ppszError);
}
