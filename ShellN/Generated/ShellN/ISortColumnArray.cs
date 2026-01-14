#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("6dfc60fb-f2e9-459b-beb5-288f1a7c7d54")]
public partial interface ISortColumnArray
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint columnCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint index, out SORTCOLUMN sortcolumn);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSortType(out SORT_ORDER_TYPE type);
}
