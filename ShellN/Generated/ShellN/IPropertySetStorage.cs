#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propidl/nn-propidl-ipropertysetstorage
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000013a-0000-0000-c000-000000000046")]
public partial interface IPropertySetStorage
{
    // https://learn.microsoft.com/windows/win32/api/propidl/nf-propidl-ipropertysetstorage-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(in Guid rfmtid, in Guid pclsid, uint grfFlags, uint grfMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStorage>))] out IPropertyStorage ppprstg);
    
    // https://learn.microsoft.com/windows/win32/api/propidl/nf-propidl-ipropertysetstorage-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(in Guid rfmtid, uint grfMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStorage>))] out IPropertyStorage ppprstg);
    
    // https://learn.microsoft.com/windows/win32/api/propidl/nf-propidl-ipropertysetstorage-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete(in Guid rfmtid);
    
    // https://learn.microsoft.com/windows/win32/api/propidl/nf-propidl-ipropertysetstorage-enum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSTATPROPSETSTG>))] out IEnumSTATPROPSETSTG ppenum);
}
