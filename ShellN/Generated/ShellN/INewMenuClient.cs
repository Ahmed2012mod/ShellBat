#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-inewmenuclient
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("dcb07fdc-3bb5-451c-90be-966644fed7b0")]
public partial interface INewMenuClient
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inewmenuclient-includeitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IncludeItems(out int pflags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inewmenuclient-selectandedititem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectAndEditItem(nint pidlItem, int flags);
}
