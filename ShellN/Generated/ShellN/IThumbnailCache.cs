#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/thumbcache/nn-thumbcache-ithumbnailcache
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f676c15d-596a-4ce2-8234-33996f445db1")]
public partial interface IThumbnailCache
{
    // https://learn.microsoft.com/windows/win32/api/thumbcache/nf-thumbcache-ithumbnailcache-getthumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnail([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem pShellItem, uint cxyRequestedThumbSize, WTS_FLAGS flags, nint /* optional ISharedBitmap* */ ppvThumb, nint /* optional WTS_CACHEFLAGS* */ pOutFlags, nint /* optional WTS_THUMBNAILID* */ pThumbnailID);
    
    // https://learn.microsoft.com/windows/win32/api/thumbcache/nf-thumbcache-ithumbnailcache-getthumbnailbyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnailByID(WTS_THUMBNAILID thumbnailID, uint cxyRequestedThumbSize, nint /* optional ISharedBitmap* */ ppvThumb, nint /* optional WTS_CACHEFLAGS* */ pOutFlags);
}
