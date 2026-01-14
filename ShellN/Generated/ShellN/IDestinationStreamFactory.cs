#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-idestinationstreamfactory
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8a87781b-39a7-4a1f-aab3-a39b9c34a7d9")]
public partial interface IDestinationStreamFactory
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idestinationstreamfactory-getdestinationstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDestinationStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppstm);
}
