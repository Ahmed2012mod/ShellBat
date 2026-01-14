#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-idefaultextracticoninit
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("41ded17d-d6b3-4261-997d-88c60e4b1d58")]
public partial interface IDefaultExtractIconInit
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idefaultextracticoninit-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(uint uFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idefaultextracticoninit-setkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetKey(HKEY hkey);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idefaultextracticoninit-setnormalicon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNormalIcon(PWSTR pszFile, int iIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idefaultextracticoninit-setopenicon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOpenIcon(PWSTR pszFile, int iIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idefaultextracticoninit-setshortcuticon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetShortcutIcon(PWSTR pszFile, int iIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idefaultextracticoninit-setdefaulticon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultIcon(PWSTR pszFile, int iIcon);
}
