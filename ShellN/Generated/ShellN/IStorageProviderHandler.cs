#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/storageprovider/nn-storageprovider-istorageproviderhandler
[GeneratedComInterface, Guid("162c6fb5-44d3-435b-903d-e613fa093fb5")]
public partial interface IStorageProviderHandler
{
    // https://learn.microsoft.com/windows/win32/api/storageprovider/nf-storageprovider-istorageproviderhandler-getpropertyhandlerfrompath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyHandlerFromPath(PWSTR path, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorageProviderPropertyHandler>))] out IStorageProviderPropertyHandler propertyHandler);
    
    // https://learn.microsoft.com/windows/win32/api/storageprovider/nf-storageprovider-istorageproviderhandler-getpropertyhandlerfromuri
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyHandlerFromUri(PWSTR uri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorageProviderPropertyHandler>))] out IStorageProviderPropertyHandler propertyHandler);
    
    // https://learn.microsoft.com/windows/win32/api/storageprovider/nf-storageprovider-istorageproviderhandler-getpropertyhandlerfromfileid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyHandlerFromFileId(PWSTR fileId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorageProviderPropertyHandler>))] out IStorageProviderPropertyHandler propertyHandler);
}
