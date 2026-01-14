#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/folderitems3-object
[GeneratedComInterface, Guid("eaa7c309-bbec-49d5-821d-64d966cb667f")]
public partial interface FolderItems3 : FolderItems2
{
    // https://learn.microsoft.com/windows/win32/shell/folderitems3-filter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Filter(int grfFlags, BSTR bstrFileSpec);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Verbs([MarshalUsing(typeof(UniqueComInterfaceMarshaller<FolderItemVerbs>))] out FolderItemVerbs ppfic);
}
