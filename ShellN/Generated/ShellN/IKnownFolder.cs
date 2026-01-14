#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iknownfolder
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("3aa7af7e-9b36-420c-a8e3-f77d4674a488")]
public partial interface IKnownFolder
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfolder-getid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetId(out Guid pkfid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfolder-getcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCategory(out KF_CATEGORY pCategory);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfolder-getshellitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShellItem(uint dwFlags, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfolder-getpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPath(uint dwFlags, out PWSTR ppszPath);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfolder-setpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPath(uint dwFlags, PWSTR pszPath);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfolder-getidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIDList(uint dwFlags, out nint ppidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfolder-getfoldertype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolderType(out Guid pftid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfolder-getredirectioncapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRedirectionCapabilities(out uint pCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iknownfolder-getfolderdefinition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolderDefinition(out KNOWNFOLDER_DEFINITION pKFD);
}
