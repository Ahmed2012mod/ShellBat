#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/thumbcache/nn-thumbcache-ithumbnailsettings
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("f4376f00-bef5-4d45-80f3-1e023bbf1209")]
public partial interface IThumbnailSettings
{
    // https://learn.microsoft.com/windows/win32/api/thumbcache/nf-thumbcache-ithumbnailsettings-setcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContext(WTS_CONTEXTFLAGS dwContext);
}
