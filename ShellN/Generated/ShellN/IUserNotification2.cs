#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iusernotification2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("215913cc-57eb-4fab-ab5a-e5fa7bea2a6c")]
public partial interface IUserNotification2
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iusernotification2-setballooninfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBalloonInfo(PWSTR pszTitle, PWSTR pszText, uint dwInfoFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iusernotification2-setballoonretry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBalloonRetry(uint dwShowTime, uint dwInterval, uint cRetryCount);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iusernotification2-seticoninfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIconInfo(HICON hIcon, PWSTR pszToolTip);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iusernotification2-show
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Show([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IQueryContinue>))] IQueryContinue pqc, uint dwContinuePollInterval, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUserNotificationCallback>))] IUserNotificationCallback pSink);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iusernotification2-playsound
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlaySound(PWSTR pszSoundName);
}
