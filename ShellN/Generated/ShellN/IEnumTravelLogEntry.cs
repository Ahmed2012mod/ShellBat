#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("7ebfdd85-ad18-11d3-a4c5-00c04f72d6b8")]
public partial interface IEnumTravelLogEntry
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cElt, [In][Out][MarshalUsing(CountElementName = nameof(cElt))] nint[] rgElt, out uint pcEltFetched);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cElt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumTravelLogEntry>))] out IEnumTravelLogEntry ppEnum);
}
