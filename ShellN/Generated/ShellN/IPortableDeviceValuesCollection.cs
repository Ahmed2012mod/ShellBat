#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevaluescollection
[GeneratedComInterface, Guid("6e3f2d79-4e07-48c4-8208-d8c2e5af4a99")]
public partial interface IPortableDeviceValuesCollection
{
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevaluescollection-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcElems);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevaluescollection-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppValues);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevaluescollection-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pValues);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevaluescollection-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevaluescollection-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAt(uint dwIndex);
}
