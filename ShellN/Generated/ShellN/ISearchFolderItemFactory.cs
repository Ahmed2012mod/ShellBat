#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-isearchfolderitemfactory
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a0ffbc28-5482-4366-be27-3e81e78e06c2")]
public partial interface ISearchFolderItemFactory
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-setdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDisplayName(PWSTR pszDisplayName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-setfoldertypeid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFolderTypeID(Guid ftid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-setfolderlogicalviewmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFolderLogicalViewMode(FOLDERLOGICALVIEWMODE flvm);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-seticonsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIconSize(int iIconSize);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-setvisiblecolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVisibleColumns(uint cVisibleColumns, [In][MarshalUsing(CountElementName = nameof(cVisibleColumns))] PROPERTYKEY[] rgKey);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-setsortcolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSortColumns(uint cSortColumns, [In][MarshalUsing(CountElementName = nameof(cSortColumns))] SORTCOLUMN[] rgSortColumns);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-setgroupcolumn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGroupColumn(in PROPERTYKEY keyGroup);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-setstacks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStacks(uint cStackKeys, [In][MarshalUsing(CountElementName = nameof(cStackKeys))] PROPERTYKEY[] rgStackKeys);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-setscope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetScope([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiaScope);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-setcondition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCondition([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICondition>))] ICondition pCondition);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-getshellitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShellItem(in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isearchfolderitemfactory-getidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIDList(out nint ppidl);
}
