#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icustomdestinationlist
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6332debf-87b5-4670-90c0-5e57b408a49e")]
public partial interface ICustomDestinationList
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icustomdestinationlist-setappid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppID(PWSTR pszAppID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icustomdestinationlist-beginlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginList(out uint pcMinSlots, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icustomdestinationlist-appendcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendCategory(PWSTR pszCategory, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IObjectArray>))] IObjectArray poa);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icustomdestinationlist-appendknowncategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendKnownCategory(KNOWNDESTCATEGORY category);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icustomdestinationlist-addusertasks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddUserTasks([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IObjectArray>))] IObjectArray poa);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icustomdestinationlist-commitlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitList();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icustomdestinationlist-getremoveddestinations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRemovedDestinations(in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icustomdestinationlist-deletelist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteList(PWSTR pszAppID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icustomdestinationlist-abortlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AbortList();
}
