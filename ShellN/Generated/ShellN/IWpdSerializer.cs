#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/iwpdserializer
[GeneratedComInterface, Guid("b32f4002-bb27-45ff-af4f-06631c1e8dad")]
public partial interface IWpdSerializer
{
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iwpdserializer-getiportabledevicevaluesfrombuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIPortableDeviceValuesFromBuffer(nint /* byte array */ pBuffer, uint dwInputBufferLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppParams);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iwpdserializer-writeiportabledevicevaluestobuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteIPortableDeviceValuesToBuffer(uint dwOutputBufferLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pResults, nint /* byte array */ pBuffer, out uint pdwBytesWritten);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iwpdserializer-getbufferfromiportabledevicevalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferFromIPortableDeviceValues([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pSource, out nint /* byte array */ ppBuffer, out uint pdwBufferSize);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iwpdserializer-getserializedsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSerializedSize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pSource, out uint pdwSize);
}
