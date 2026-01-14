#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/thumbcache/nn-thumbcache-ithumbnailprovider
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e357fccd-a995-4576-b01f-234630154e96")]
public partial interface IThumbnailProvider
{
    // https://learn.microsoft.com/windows/win32/api/thumbcache/nf-thumbcache-ithumbnailprovider-getthumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnail(uint cx, out HBITMAP phbmp, out WTS_ALPHATYPE pdwAlpha);
}
