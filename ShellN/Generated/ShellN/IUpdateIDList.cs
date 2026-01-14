#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iupdateidlist
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6589b6d2-5f8d-4b9e-b7e0-23cdd9717d8c")]
public partial interface IUpdateIDList
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iupdateidlist-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Update([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx?>))] IBindCtx? pbc, nint pidlIn, out nint ppidlOut);
}
