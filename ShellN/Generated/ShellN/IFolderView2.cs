#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifolderview2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("1af3a467-214f-4298-908e-06b03e0b39f9")]
public partial interface IFolderView2 : IFolderView
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-setgroupby
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGroupBy(in PROPERTYKEY key, BOOL fAscending);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getgroupby
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGroupBy(out PROPERTYKEY pkey, nint /* optional BOOL* */ pfAscending);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-setviewproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetViewProperty(nint pidl, in PROPERTYKEY propkey, in PROPVARIANT propvar);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getviewproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewProperty(nint pidl, in PROPERTYKEY propkey, out PROPVARIANT ppropvar);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-settileviewproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTileViewProperties(nint pidl, PWSTR pszPropList);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-setextendedtileviewproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetExtendedTileViewProperties(nint pidl, PWSTR pszPropList);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-settext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetText(FVTEXTTYPE iType, PWSTR pwszText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-setcurrentfolderflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentFolderFlags(uint dwMask, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getcurrentfolderflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentFolderFlags(out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getsortcolumncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSortColumnCount(out int pcColumns);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-setsortcolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSortColumns([In][MarshalUsing(CountElementName = nameof(cColumns))] SORTCOLUMN[] rgSortColumns, int cColumns);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getsortcolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSortColumns([In][Out][MarshalUsing(CountElementName = nameof(cColumns))] SORTCOLUMN[] rgSortColumns, int cColumns);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItem(int iItem, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getvisibleitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVisibleItem(int iStart, BOOL fPrevious, out int piItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getselecteditem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelectedItem(int iStart, out int piItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelection(BOOL fNoneImpliesFolder, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] out IShellItemArray ppsia);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getselectionstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelectionState(nint pidl, out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-invokeverbonselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeVerbOnSelection(PSTR pszVerb);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-setviewmodeandiconsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetViewModeAndIconSize(FOLDERVIEWMODE uViewMode, int iImageSize);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getviewmodeandiconsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewModeAndIconSize(out FOLDERVIEWMODE puViewMode, out int piImageSize);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-setgroupsubsetcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGroupSubsetCount(uint cVisibleRows);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-getgroupsubsetcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGroupSubsetCount(out uint pcVisibleRows);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-setredraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedraw(BOOL fRedrawOn);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-ismoveinsamefolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsMoveInSameFolder();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview2-dorename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoRename();
}
