#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("79eac9c7-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IHlinkBrowseContext
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Register(uint reserved, nint piunk, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pimk, out uint pdwRegister);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pimk, BOOL fBindIfRootRegistered, out nint ppiunk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Revoke(uint dwRegister);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBrowseWindowInfo(in HLBWINFO phlbwi);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBrowseWindowInfo(out HLBWINFO phlbwi);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInitialHlink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pimkTarget, PWSTR pwzLocation, PWSTR pwzFriendlyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnNavigateHlink(uint grfHLNF, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pimkTarget, PWSTR pwzLocation, PWSTR pwzFriendlyName, out uint puHLID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateHlink(uint uHLID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pimkTarget, PWSTR pwzLocation, PWSTR pwzFriendlyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumNavigationStack(uint dwReserved, uint grfHLFNAMEF, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumHLITEM>))] out IEnumHLITEM ppienumhlitem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryHlink(uint grfHLQF, uint uHLID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHlink(uint uHLID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHlink>))] out IHlink ppihl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentHlink(uint uHLID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(nint piunkOuter, in Guid riid, out nint ppiunkObj);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close(uint reserved);
}
