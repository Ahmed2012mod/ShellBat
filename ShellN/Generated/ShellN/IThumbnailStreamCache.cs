#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/thumbnailstreamcache/nn-thumbnailstreamcache-ithumbnailstreamcache
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("90e11430-9569-41d8-ae75-6d4d2ae7cca0")]
public partial interface IThumbnailStreamCache
{
    // https://learn.microsoft.com/windows/win32/api/thumbnailstreamcache/nf-thumbnailstreamcache-ithumbnailstreamcache-getthumbnailstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnailStream(PWSTR path, ulong cacheId, ThumbnailStreamCacheOptions options, uint requestedThumbnailSize, out SIZE thumbnailSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream thumbnailStream);
    
    // https://learn.microsoft.com/windows/win32/api/thumbnailstreamcache/nf-thumbnailstreamcache-ithumbnailstreamcache-setthumbnailstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetThumbnailStream(PWSTR path, ulong cacheId, SIZE thumbnailSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream thumbnailStream);
}
