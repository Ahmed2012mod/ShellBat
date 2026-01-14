#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nn-portabledeviceapi-iportabledevicecapabilities
[GeneratedComInterface, Guid("2c8c6dbf-e3dc-4061-becc-8542e810d126")]
public partial interface IPortableDeviceCapabilities
{
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-getsupportedcommands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedCommands([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] out IPortableDeviceKeyCollection ppCommands);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-getcommandoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCommandOptions(in PROPERTYKEY Command, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppOptions);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-getfunctionalcategories
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFunctionalCategories([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppCategories);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-getfunctionalobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFunctionalObjects(in Guid Category, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppObjectIDs);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-getsupportedcontenttypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedContentTypes(in Guid Category, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppContentTypes);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-getsupportedformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedFormats(in Guid ContentType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppFormats);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-getsupportedformatproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedFormatProperties(in Guid Format, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceKeyCollection>))] out IPortableDeviceKeyCollection ppKeys);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-getfixedpropertyattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFixedPropertyAttributes(in Guid Format, in PROPERTYKEY Key, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-getsupportedevents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedEvents([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDevicePropVariantCollection>))] out IPortableDevicePropVariantCollection ppEvents);
    
    // https://learn.microsoft.com/windows/win32/api/portabledeviceapi/nf-portabledeviceapi-iportabledevicecapabilities-geteventoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventOptions(in Guid Event, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPortableDeviceValues>))] out IPortableDeviceValues ppOptions);
}
