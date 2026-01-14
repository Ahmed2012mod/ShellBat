#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ithumbnailhandlerfactory
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e35b4b2e-00da-4bc1-9f13-38bc11f5d417")]
public partial interface IThumbnailHandlerFactory
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ithumbnailhandlerfactory-getthumbnailhandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnailHandler(nint pidlChild, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pbc, in Guid riid, out nint /* void */ ppv);
}
