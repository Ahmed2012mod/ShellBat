#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializewithpropertystore
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c3e12eb5-7d8d-44f8-b6dd-0e77b34d6de4")]
public partial interface IInitializeWithPropertyStore
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinitializewithpropertystore-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pps);
}
