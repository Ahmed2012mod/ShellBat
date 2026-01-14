#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("8d7b2ba7-db05-46a8-823c-d2b6de08ee91")]
public partial interface IBannerNotificationHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnBannerEvent(in BANNER_NOTIFICATION notification);
}
