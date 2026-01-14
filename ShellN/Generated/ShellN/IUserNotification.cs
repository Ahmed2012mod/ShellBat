#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iusernotification
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ba9711ba-5893-4787-a7e1-41277151550b")]
public partial interface IUserNotification
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iusernotification-setballooninfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBalloonInfo(PWSTR pszTitle, PWSTR pszText, uint dwInfoFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iusernotification-setballoonretry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBalloonRetry(uint dwShowTime, uint dwInterval, uint cRetryCount);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iusernotification-seticoninfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIconInfo(HICON hIcon, PWSTR pszToolTip);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iusernotification-show
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Show([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IQueryContinue>))] IQueryContinue pqc, uint dwContinuePollInterval);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iusernotification-playsound
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlaySound(PWSTR pszSoundName);
}
