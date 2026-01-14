#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicekeycollection
[GeneratedComInterface, Guid("dada2357-e0ad-492e-98db-dd61c53ba353")]
public partial interface IPortableDeviceKeyCollection
{
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicekeycollection-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcElems);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicekeycollection-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint dwIndex, out PROPERTYKEY pKey);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicekeycollection-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add(in PROPERTYKEY Key);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicekeycollection-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicekeycollection-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAt(uint dwIndex);
}
