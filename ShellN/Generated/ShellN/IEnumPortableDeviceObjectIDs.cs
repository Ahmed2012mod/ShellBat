#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-ienumportabledeviceobjectids
[GeneratedComInterface, Guid("10ece955-cf41-4728-bfa0-41eedf1bbf19")]
public partial interface IEnumPortableDeviceObjectIDs
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-ienumportabledeviceobjectids-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cObjects, [In][Out][MarshalUsing(CountElementName = nameof(cObjects))] PWSTR[] pObjIDs, ref uint pcFetched);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-ienumportabledeviceobjectids-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cObjects);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-ienumportabledeviceobjectids-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-ienumportabledeviceobjectids-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumPortableDeviceObjectIDs>))] out IEnumPortableDeviceObjectIDs ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-ienumportabledeviceobjectids-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
}
