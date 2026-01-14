#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifolderviewsettings
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("ae8c987d-8797-4ed3-be72-2a47dd938db0")]
public partial interface IFolderViewSettings
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderviewsettings-getcolumnpropertylist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColumnPropertyList(in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderviewsettings-getgroupbyproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGroupByProperty(out PROPERTYKEY pkey, out BOOL pfGroupAscending);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderviewsettings-getviewmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewMode(out FOLDERLOGICALVIEWMODE plvm);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderviewsettings-geticonsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIconSize(out uint puIconSize);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderviewsettings-getfolderflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolderFlags(out FOLDERFLAGS pfolderMask, out FOLDERFLAGS pfolderFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderviewsettings-getsortcolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSortColumns([In][Out][MarshalUsing(CountElementName = nameof(cColumnsIn))] SORTCOLUMN[] rgSortColumns, uint cColumnsIn, out uint pcColumnsOut);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderviewsettings-getgroupsubsetcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGroupSubsetCount(out uint pcVisibleRows);
}
