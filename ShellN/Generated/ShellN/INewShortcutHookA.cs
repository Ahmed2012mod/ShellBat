#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/nn-shlobj-inewshortcuthooka
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214e1-0000-0000-c000-000000000046")]
public partial interface INewShortcutHookA
{
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthooka-setreferent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReferent(PSTR pcszReferent, HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthooka-getreferent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReferent([MarshalUsing(CountElementName = nameof(cchReferent))] PSTR pszReferent, int cchReferent);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthooka-setfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFolder(PSTR pcszFolder);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthooka-getfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolder([MarshalUsing(CountElementName = nameof(cchFolder))] PSTR pszFolder, int cchFolder);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthooka-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName([MarshalUsing(CountElementName = nameof(cchName))] PSTR pszName, int cchName);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-inewshortcuthooka-getextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtension([MarshalUsing(CountElementName = nameof(cchExtension))] PSTR pszExtension, int cchExtension);
}
