#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("e572d3c9-37be-4ae2-825d-d521763e3108")]
public partial interface IShellNameSpace : IShellFavoritesNameSpace
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnumOptions(out int pgrfEnumFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EnumOptions(int lVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SelectedItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch pItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SelectedItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch pItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Root(out VARIANT pvar);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Root(VARIANT var);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Depth(out int piDepth);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Depth(int iDepth);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Mode(out uint puMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Mode(uint uMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Flags(out uint pdwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Flags(uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TVFlags(uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TVFlags(out uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Columns(out BSTR bstrColumns);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Columns(BSTR bstrColumns);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CountViewTypes(out int piTypes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetViewType(int iType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectedItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Expand(VARIANT var, int iDepth);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnselectAll();
}
