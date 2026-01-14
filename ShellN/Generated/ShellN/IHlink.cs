#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("79eac9c3-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IHlink
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHlinkSite([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHlinkSite>))] IHlinkSite pihlSite, uint dwSiteData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHlinkSite([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHlinkSite>))] out IHlinkSite ppihlSite, out uint pdwSiteData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMonikerReference(uint grfHLSETF, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pimkTarget, PWSTR pwzLocation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMonikerReference(uint dwWhichRef, nint /* optional IMoniker* */ ppimkTarget, nint /* optional PWSTR* */ ppwzLocation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStringReference(uint grfHLSETF, PWSTR pwzTarget, PWSTR pwzLocation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringReference(uint dwWhichRef, nint /* optional PWSTR* */ ppwzTarget, nint /* optional PWSTR* */ ppwzLocation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFriendlyName(PWSTR pwzFriendlyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFriendlyName(uint grfHLFNAMEF, out PWSTR ppwzFriendlyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTargetFrameName(PWSTR pwzTargetFrameName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTargetFrameName(out PWSTR ppwzTargetFrameName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMiscStatus(out uint pdwStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Navigate(uint grfHLNF, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pibc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindStatusCallback>))] IBindStatusCallback pibsc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHlinkBrowseContext>))] IHlinkBrowseContext pihlbc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAdditionalParams(PWSTR pwzAdditionalParams);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdditionalParams(out PWSTR ppwzAdditionalParams);
}
