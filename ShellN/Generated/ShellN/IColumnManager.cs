#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icolumnmanager
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d8ec27bb-3f3b-4042-b10a-4acfd924d453")]
public partial interface IColumnManager
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icolumnmanager-setcolumninfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColumnInfo(in PROPERTYKEY propkey, in CM_COLUMNINFO pcmci);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icolumnmanager-getcolumninfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColumnInfo(in PROPERTYKEY propkey, ref CM_COLUMNINFO pcmci);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icolumnmanager-getcolumncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColumnCount(CM_ENUM_FLAGS dwFlags, out uint puCount);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icolumnmanager-getcolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColumns(CM_ENUM_FLAGS dwFlags, [In][Out][MarshalUsing(CountElementName = nameof(cColumns))] PROPERTYKEY[] rgkeyOrder, uint cColumns);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icolumnmanager-setcolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColumns([In][MarshalUsing(CountElementName = nameof(cVisible))] PROPERTYKEY[] rgkeyOrder, uint cVisible);
}
