#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellitemfilter
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2659b475-eeb8-48b7-8f07-b378810f48cf")]
public partial interface IShellItemFilter
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemfilter-includeitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IncludeItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemfilter-getenumflagsforitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumFlagsForItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, out uint pgrfFlags);
}
