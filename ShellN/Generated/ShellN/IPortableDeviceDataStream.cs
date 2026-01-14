#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledevicedatastream
[GeneratedComInterface, Guid("88e04db3-1012-4d64-9996-f703a950d3f4")]
public partial interface IPortableDeviceDataStream : IStream
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicedatastream-getobjectid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectID(out PWSTR ppszObjectID);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicedatastream-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
}
