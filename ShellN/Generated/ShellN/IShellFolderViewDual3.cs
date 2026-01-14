#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shldisp/nn-shldisp-ishellfolderviewdual3
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("29ec8e6c-46d3-411f-baaa-611a6c9cac66")]
public partial interface IShellFolderViewDual3 : IShellFolderViewDual2
{
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual3-get_groupby
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_GroupBy(out BSTR pbstrGroupBy);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual3-put_groupby
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_GroupBy(BSTR bstrGroupBy);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual3-get_folderflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FolderFlags(out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual3-put_folderflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FolderFlags(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual3-get_sortcolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SortColumns(out BSTR pbstrSortColumns);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual3-put_sortcolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SortColumns(BSTR bstrSortColumns);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual3-put_iconsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IconSize(int iIconSize);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual3-get_iconsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IconSize(out int piIconSize);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual3-filterview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FilterView(BSTR bstrFilterText);
}
