#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/storageprovider/nn-storageprovider-istorageproviderpropertyhandler
[GeneratedComInterface, Guid("301dfbe5-524c-4b0f-8b2d-21c40b3a2988")]
public partial interface IStorageProviderPropertyHandler
{
    // https://learn.microsoft.com/windows/win32/api/storageprovider/nf-storageprovider-istorageproviderpropertyhandler-retrieveproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RetrieveProperties([In][MarshalUsing(CountElementName = nameof(propertiesToRetrieveCount))] PROPERTYKEY[] propertiesToRetrieve, uint propertiesToRetrieveCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] out IPropertyStore retrievedProperties);
    
    // https://learn.microsoft.com/windows/win32/api/storageprovider/nf-storageprovider-istorageproviderpropertyhandler-saveproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveProperties([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore propertiesToSave);
}
