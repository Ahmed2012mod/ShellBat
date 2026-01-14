#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledeviceunitsstream
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("5e98025f-bfc4-47a2-9a5f-bc900a507c67")]
public partial interface IPortableDeviceUnitsStream
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceunitsstream-seekinunits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SeekInUnits(long dlibMove, WPD_STREAM_UNITS units, uint dwOrigin, nint /* optional ulong* */ plibNewPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
}
