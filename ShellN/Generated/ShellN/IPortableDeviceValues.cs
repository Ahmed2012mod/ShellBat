#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues
[GeneratedComInterface, Guid("6848f6f2-3155-4f86-b6f5-263eeeab3143")]
public partial interface IPortableDeviceValues
{
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcelt);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAt(uint index, ref PROPERTYKEY pKey, ref PROPVARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValue(in PROPERTYKEY key, in PROPVARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(in PROPERTYKEY key, out PROPVARIANT pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setstringvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStringValue(in PROPERTYKEY key, PWSTR Value);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getstringvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringValue(in PROPERTYKEY key, out PWSTR pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setunsignedintegervalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnsignedIntegerValue(in PROPERTYKEY key, uint Value);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getunsignedintegervalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnsignedIntegerValue(in PROPERTYKEY key, out uint pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setsignedintegervalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSignedIntegerValue(in PROPERTYKEY key, int Value);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getsignedintegervalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignedIntegerValue(in PROPERTYKEY key, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setunsignedlargeintegervalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnsignedLargeIntegerValue(in PROPERTYKEY key, ulong Value);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getunsignedlargeintegervalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnsignedLargeIntegerValue(in PROPERTYKEY key, out ulong pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setsignedlargeintegervalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSignedLargeIntegerValue(in PROPERTYKEY key, long Value);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getsignedlargeintegervalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignedLargeIntegerValue(in PROPERTYKEY key, out long pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setfloatvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFloatValue(in PROPERTYKEY key, float Value);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getfloatvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFloatValue(in PROPERTYKEY key, out float pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-seterrorvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetErrorValue(in PROPERTYKEY key, HRESULT Value);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-geterrorvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetErrorValue(in PROPERTYKEY key, out HRESULT pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setkeyvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetKeyValue(in PROPERTYKEY key, in PROPERTYKEY Value);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getkeyvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeyValue(in PROPERTYKEY key, out PROPERTYKEY pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setboolvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBoolValue(in PROPERTYKEY key, BOOL Value);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getboolvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBoolValue(in PROPERTYKEY key, out BOOL pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setiunknownvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIUnknownValue(in PROPERTYKEY key, nint pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getiunknownvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIUnknownValue(in PROPERTYKEY key, out nint ppValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setguidvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGuidValue(in PROPERTYKEY key, in Guid Value);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getguidvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGuidValue(in PROPERTYKEY key, out Guid pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setbuffervalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBufferValue(in PROPERTYKEY key, nint /* byte array */ pValue, uint cbValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getbuffervalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferValue(in PROPERTYKEY key, out nint /* byte array */ ppValue, out uint pcbValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setiportabledevicevaluesvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIPortableDeviceValuesValue(in PROPERTYKEY key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] IPortableDeviceValues pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getiportabledevicevaluesvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIPortableDeviceValuesValue(in PROPERTYKEY key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setiportabledevicepropvariantcollectionvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIPortableDevicePropVariantCollectionValue(in PROPERTYKEY key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] IPortableDevicePropVariantCollection pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getiportabledevicepropvariantcollectionvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIPortableDevicePropVariantCollectionValue(in PROPERTYKEY key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setiportabledevicekeycollectionvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIPortableDeviceKeyCollectionValue(in PROPERTYKEY key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] IPortableDeviceKeyCollection pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getiportabledevicekeycollectionvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIPortableDeviceKeyCollectionValue(in PROPERTYKEY key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] out IPortableDeviceKeyCollection ppValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-setiportabledevicevaluescollectionvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIPortableDeviceValuesCollectionValue(in PROPERTYKEY key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValuesCollection>))] IPortableDeviceValuesCollection pValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-getiportabledevicevaluescollectionvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIPortableDeviceValuesCollectionValue(in PROPERTYKEY key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValuesCollection>))] out IPortableDeviceValuesCollection ppValue);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-removevalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveValue(in PROPERTYKEY key);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-copyvaluesfrompropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyValuesFromPropertyStore([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pStore);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-copyvaluestopropertystore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyValuesToPropertyStore([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pStore);
    
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iportabledevicevalues-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
}
