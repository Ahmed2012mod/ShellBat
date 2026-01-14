#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("e56b0534-d9b9-425c-9b99-75f97cb3d7c8")]
public partial interface IPortableDeviceServiceActivation
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenAsync(PWSTR pszPnPServiceID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pClientInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceServiceOpenCallback>))] IPortableDeviceServiceOpenCallback pCallback);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelOpenAsync();
}
