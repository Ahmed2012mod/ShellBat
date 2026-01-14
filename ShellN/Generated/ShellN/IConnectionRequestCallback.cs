#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/iconnectionrequestcallback
[GeneratedComInterface, Guid("272c9ae0-7161-4ae0-91bd-9f448ee9c427")]
public partial interface IConnectionRequestCallback
{
    // https://learn.microsoft.com/windows/win32/wpd_sdk/iconnectionrequestcallback-oncomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnComplete(HRESULT hrStatus);
}
