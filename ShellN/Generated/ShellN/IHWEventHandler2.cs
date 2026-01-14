#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ihweventhandler2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("cfcc809f-295d-42e8-9ffc-424b33c487e6")]
public partial interface IHWEventHandler2 : IHWEventHandler
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ihweventhandler2-handleeventwithhwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HandleEventWithHWND(PWSTR pszDeviceID, PWSTR pszAltDeviceID, PWSTR pszEventType, HWND hwndOwner);
}
