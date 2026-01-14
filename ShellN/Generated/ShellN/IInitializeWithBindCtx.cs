#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializewithbindctx
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("71c0d2bc-726d-45cc-a6c0-2e31c1db2159")]
public partial interface IInitializeWithBindCtx
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinitializewithbindctx-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc);
}
