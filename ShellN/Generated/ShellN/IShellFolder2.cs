#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellfolder2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("93f2f68c-1d1b-11d3-a30e-00c04f79abd1")]
public partial interface IShellFolder2 : IShellFolder
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder2-getdefaultsearchguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultSearchGUID(out Guid pguid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder2-enumsearches
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumSearches([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumExtraSearch>))] out IEnumExtraSearch ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder2-getdefaultcolumn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultColumn(uint dwRes, out uint pSort, out uint pDisplay);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder2-getdefaultcolumnstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultColumnState(uint iColumn, out SHCOLSTATE pcsFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder2-getdetailsex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDetailsEx(nint pidl, in PROPERTYKEY pscid, out VARIANT pv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder2-getdetailsof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDetailsOf(nint pidl, uint iColumn, out SHELLDETAILS psd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder2-mapcolumntoscid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapColumnToSCID(uint iColumn, out PROPERTYKEY pscid);
}
