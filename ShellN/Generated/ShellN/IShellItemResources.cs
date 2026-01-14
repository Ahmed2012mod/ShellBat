#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellitemresources
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("ff5693be-2ce0-4d48-b5c5-40817d1acdb9")]
public partial interface IShellItemResources
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemresources-getattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributes(out uint pdwAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemresources-getsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSize(out ulong pullSize);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemresources-gettimes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimes(out FILETIME pftCreation, out FILETIME pftWrite, out FILETIME pftAccess);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemresources-settimes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimes(in FILETIME pftCreation, in FILETIME pftWrite, in FILETIME pftAccess);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemresources-getresourcedescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceDescription(in SHELL_ITEM_RESOURCE pcsir, out PWSTR ppszDescription);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemresources-enumresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumResources([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumResources>))] out IEnumResources ppenumr);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemresources-supportsresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SupportsResource(in SHELL_ITEM_RESOURCE pcsir);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemresources-openresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenResource(in SHELL_ITEM_RESOURCE pcsir, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemresources-createresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateResource(in SHELL_ITEM_RESOURCE pcsir, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemresources-markfordelete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MarkForDelete();
}
