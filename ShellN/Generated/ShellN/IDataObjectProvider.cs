#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-idataobjectprovider
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3d25f6d6-4b2a-433c-9184-7c33ad35d001")]
public partial interface IDataObjectProvider
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idataobjectprovider-getdataobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] out IDataObject dataObject);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idataobjectprovider-setdataobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDataObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject dataObject);
}
