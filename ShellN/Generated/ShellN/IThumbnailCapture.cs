#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/nn-shlobj-ithumbnailcapture
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("4ea39266-7211-409f-b622-f63dbd16c533")]
public partial interface IThumbnailCapture
{
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-ithumbnailcapture-capturethumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CaptureThumbnail(in SIZE pMaxSize, nint pHTMLDoc2, out HBITMAP phbmThumbnail);
}
