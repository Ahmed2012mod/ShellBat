#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("79eac9c6-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IEnumHLITEM
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, out HLITEM rgelt, out uint pceltFetched);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumHLITEM>))] out IEnumHLITEM ppienumhlitem);
}
