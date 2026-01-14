#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/nn-shlobj-inewshortcuthookw
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214f7-0000-0000-c000-000000000046")]
public partial interface INewShortcutHookW
{
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthookw-setreferent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReferent(PWSTR pcszReferent, HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthookw-getreferent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReferent([MarshalUsing(CountElementName = nameof(cchReferent))] PWSTR pszReferent, int cchReferent);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthookw-setfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFolder(PWSTR pcszFolder);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthookw-getfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolder([MarshalUsing(CountElementName = nameof(cchFolder))] PWSTR pszFolder, int cchFolder);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthookw-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName([MarshalUsing(CountElementName = nameof(cchName))] PWSTR pszName, int cchName);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthookw-getextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtension([MarshalUsing(CountElementName = nameof(cchExtension))] PWSTR pszExtension, int cchExtension);
}
