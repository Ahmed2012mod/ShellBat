#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishelllinka
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214ee-0000-0000-c000-000000000046")]
public partial interface IShellLinkA
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-getpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPath([MarshalUsing(CountElementName = nameof(cch))] PSTR pszFile, int cch, ref WIN32_FIND_DATAA pfd, uint fFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-getidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIDList(out nint ppidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-setidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIDList(nint pidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-getdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription([MarshalUsing(CountElementName = nameof(cch))] PSTR pszName, int cch);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-setdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDescription(PSTR pszName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-getworkingdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWorkingDirectory([MarshalUsing(CountElementName = nameof(cch))] PSTR pszDir, int cch);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-setworkingdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWorkingDirectory(PSTR pszDir);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-getarguments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetArguments([MarshalUsing(CountElementName = nameof(cch))] PSTR pszArgs, int cch);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-setarguments
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetArguments(PSTR pszArgs);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-gethotkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHotkey(out ushort pwHotkey);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-sethotkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHotkey(ushort wHotkey);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-getshowcmd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShowCmd(out SHOW_WINDOW_CMD piShowCmd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-setshowcmd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetShowCmd(SHOW_WINDOW_CMD iShowCmd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-geticonlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIconLocation([MarshalUsing(CountElementName = nameof(cch))] PSTR pszIconPath, int cch, out int piIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-seticonlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIconLocation(PSTR pszIconPath, int iIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-setrelativepath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRelativePath(PSTR pszPathRel, uint dwReserved);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-resolve
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resolve(HWND hwnd, uint fFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinka-setpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPath(PSTR pszFile);
}
