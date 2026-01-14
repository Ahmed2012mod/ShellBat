#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledevicecontent2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("9b4add96-f6bf-4034-8708-eca72bf10554")]
public partial interface IPortableDeviceContent2 : IPortableDeviceContent
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecontent2-updateobjectwithpropertiesanddata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateObjectWithPropertiesAndData(PWSTR pszObjectID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppData, ref uint pdwOptimalWriteBufferSize);
}
