#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/thumbnailstreamcache/ne-thumbnailstreamcache-thumbnailstreamcacheoptions
[Flags]
public enum ThumbnailStreamCacheOptions
{
    ExtractIfNotCached = 0,
    ReturnOnlyIfCached = 1,
    ResizeThumbnail = 2,
    AllowSmallerSize = 4,
}
