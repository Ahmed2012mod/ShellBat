#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("e5791fae-5665-4e0c-95be-5fde31644185")]
public partial interface IRadioInstanceCollection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcInstance);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint uIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRadioInstance>))] out IRadioInstance ppRadioInstance);
}
