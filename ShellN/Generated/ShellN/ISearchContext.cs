#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-isearchcontext
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("09f656a2-41af-480c-88f7-16cc0d164615")]
public partial interface ISearchContext
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-isearchcontext-getsearchurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSearchUrl(out BSTR pbstrSearchUrl);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-isearchcontext-getsearchtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSearchText(out BSTR pbstrSearchText);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-isearchcontext-getsearchstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSearchStyle(out uint pdwSearchStyle);
}
