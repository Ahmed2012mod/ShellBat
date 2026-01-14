#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("79eac9c2-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IHlinkSite
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryService(uint dwSiteData, in Guid guidService, in Guid riid, out nint ppiunk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMoniker(uint dwSiteData, uint dwAssign, uint dwWhich, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppimk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadyToNavigate(uint dwSiteData, uint dwReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnNavigationComplete(uint dwSiteData, uint dwreserved, HRESULT hrError, PWSTR pwzError);
}
