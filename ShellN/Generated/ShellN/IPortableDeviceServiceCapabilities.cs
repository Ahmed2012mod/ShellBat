#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledeviceservicecapabilities
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("24dbd89d-413e-43e0-bd5b-197f3c56c886")]
public partial interface IPortableDeviceServiceCapabilities
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getsupportedmethods
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedMethods([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppMethods);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getsupportedmethodsbyformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedMethodsByFormat(in Guid Format, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppMethods);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getmethodattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMethodAttributes(in Guid Method, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getmethodparameterattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMethodParameterAttributes(in Guid Method, in PROPERTYKEY Parameter, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getsupportedformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedFormats([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppFormats);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getformatattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatAttributes(in Guid Format, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getsupportedformatproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedFormatProperties(in Guid Format, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] out IPortableDeviceKeyCollection ppKeys);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getformatpropertyattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatPropertyAttributes(in Guid Format, in PROPERTYKEY Property, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getsupportedevents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedEvents([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppEvents);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-geteventattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventAttributes(in Guid Event, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-geteventparameterattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventParameterAttributes(in Guid Event, in PROPERTYKEY Parameter, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getinheritedservices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInheritedServices(uint dwInheritanceType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppServices);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getformatrenderingprofiles
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormatRenderingProfiles(in Guid Format, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValuesCollection>))] out IPortableDeviceValuesCollection ppRenderingProfiles);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getsupportedcommands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedCommands([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] out IPortableDeviceKeyCollection ppCommands);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-getcommandoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCommandOptions(in PROPERTYKEY Command, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppOptions);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledeviceservicecapabilities-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
}
