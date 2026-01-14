#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicepropvariantcollection
[GeneratedComInterface, Guid("89b2e422-4f1b-4316-bcef-a44afea83eb3")]
public partial interface IPortableDevicePropVariantCollection
{
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicepropvariantcollection-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcElems);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicepropvariantcollection-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint dwIndex, out PROPERTYKEY pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicepropvariantcollection-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add(in PROPVARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicepropvariantcollection-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out ushort pvt);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicepropvariantcollection-changetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeType(ushort vt);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicepropvariantcollection-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicepropvariantcollection-removeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAt(uint dwIndex);
}
