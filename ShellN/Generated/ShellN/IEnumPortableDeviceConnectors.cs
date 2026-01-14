#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/ienumportabledeviceconnectors
[GeneratedComInterface, Guid("bfdef549-9247-454f-bd82-06fe80853faa")]
public partial interface IEnumPortableDeviceConnectors
{
    // https://learn.microsoft.com/windows/win32/wpd_sdk/ienumportabledeviceconnectors-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cRequested, [In][Out][MarshalUsing(CountElementName = nameof(cRequested))] nint[] pConnectors, ref uint pcFetched);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/ienumportabledeviceconnectors-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cConnectors);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/ienumportabledeviceconnectors-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/ienumportabledeviceconnectors-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumPortableDeviceConnectors>))] out IEnumPortableDeviceConnectors ppEnum);
}
