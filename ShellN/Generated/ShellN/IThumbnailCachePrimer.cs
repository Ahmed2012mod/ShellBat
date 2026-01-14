#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/thumbcache/nn-thumbcache-ithumbnailcacheprimer
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("0f03f8fe-2b26-46f0-965a-212aa8d66b76")]
public partial interface IThumbnailCachePrimer
{
    // https://learn.microsoft.com/windows/win32/api/thumbcache/nf-thumbcache-ithumbnailcacheprimer-pageinthumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PageInThumbnail([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, WTS_FLAGS wtsFlags, uint cxyRequestedThumbSize);
}
