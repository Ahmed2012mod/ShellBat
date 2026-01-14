#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifolderview
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("cde725b0-ccc9-4519-917e-325d72fab4ce")]
public partial interface IFolderView
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-getcurrentviewmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentViewMode(out uint pViewMode);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-setcurrentviewmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentViewMode(uint ViewMode);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-getfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolder(in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int iItemIndex, out nint ppidl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-itemcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ItemCount(uint uFlags, out int pcItems);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-items
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Items(uint uFlags, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-getselectionmarkeditem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelectionMarkedItem(out int piItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-getfocuseditem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFocusedItem(out int piItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-getitemposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemPosition(nint pidl, out POINT ppt);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-getspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpacing(ref POINT ppt);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-getdefaultspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultSpacing(out POINT ppt);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-getautoarrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutoArrange();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-selectitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectItem(int iItem, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderview-selectandpositionitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectAndPositionItems(uint cidl, [In][Out][MarshalUsing(CountElementName = nameof(cidl))] nint[] apidl, nint /* optional POINT* */ apt, uint dwFlags);
}
