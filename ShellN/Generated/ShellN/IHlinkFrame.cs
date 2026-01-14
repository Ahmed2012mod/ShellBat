#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("79eac9c5-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IHlinkFrame
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBrowseContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHlinkBrowseContext>))] IHlinkBrowseContext pihlbc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBrowseContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHlinkBrowseContext>))] out IHlinkBrowseContext ppihlbc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Navigate(uint grfHLNF, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindStatusCallback>))] IBindStatusCallback pibsc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHlink>))] IHlink pihlNavigate);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnNavigate(uint grfHLNF, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pimkTarget, PWSTR pwzLocation, PWSTR pwzFriendlyName, uint dwreserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateHlink(uint uHLID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pimkTarget, PWSTR pwzLocation, PWSTR pwzFriendlyName);
}
