#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishelllinkw
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214f9-0000-0000-c000-000000000046")]
public partial interface IShellLinkW
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-getpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPath([MarshalUsing(CountElementName = nameof(cch))] PWSTR pszFile, int cch, ref WIN32_FIND_DATAW pfd, uint fFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-getidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIDList(out nint ppidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-setidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIDList(nint pidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-getdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription([MarshalUsing(CountElementName = nameof(cch))] PWSTR pszName, int cch);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-setdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDescription(PWSTR pszName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-getworkingdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWorkingDirectory([MarshalUsing(CountElementName = nameof(cch))] PWSTR pszDir, int cch);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-setworkingdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWorkingDirectory(PWSTR pszDir);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-getarguments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArguments([MarshalUsing(CountElementName = nameof(cch))] PWSTR pszArgs, int cch);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-setarguments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetArguments(PWSTR pszArgs);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-gethotkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHotkey(out ushort pwHotkey);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-sethotkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHotkey(ushort wHotkey);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-getshowcmd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShowCmd(out SHOW_WINDOW_CMD piShowCmd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-setshowcmd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetShowCmd(SHOW_WINDOW_CMD iShowCmd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-geticonlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIconLocation([MarshalUsing(CountElementName = nameof(cch))] PWSTR pszIconPath, int cch, out int piIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-seticonlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIconLocation(PWSTR pszIconPath, int iIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-setrelativepath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRelativePath(PWSTR pszPathRel, uint dwReserved);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-resolve
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resolve(HWND hwnd, uint fFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkw-setpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPath(PWSTR pszFile);
}
