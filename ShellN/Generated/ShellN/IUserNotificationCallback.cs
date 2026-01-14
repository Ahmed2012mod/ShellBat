#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iusernotificationcallback
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("19108294-0441-4aff-8013-fa0a730b0bea")]
public partial interface IUserNotificationCallback
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iusernotificationcallback-onballoonuserclick
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnBalloonUserClick(in POINT pt);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iusernotificationcallback-onleftclick
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnLeftClick(in POINT pt);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iusernotificationcallback-oncontextmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnContextMenu(in POINT pt);
}
