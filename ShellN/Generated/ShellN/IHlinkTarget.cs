#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("79eac9c4-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IHlinkTarget
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBrowseContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHlinkBrowseContext>))] IHlinkBrowseContext pihlbc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBrowseContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHlinkBrowseContext>))] out IHlinkBrowseContext ppihlbc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Navigate(uint grfHLNF, PWSTR pwzJumpLocation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMoniker(PWSTR pwzLocation, uint dwAssign, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppimkLocation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFriendlyName(PWSTR pwzLocation, out PWSTR ppwzFriendlyName);
}
