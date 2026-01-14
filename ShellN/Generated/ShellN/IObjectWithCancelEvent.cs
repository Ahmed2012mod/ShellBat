#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iobjectwithcancelevent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f279b885-0ae9-4b85-ac06-ddecf9408941")]
public partial interface IObjectWithCancelEvent
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectwithcancelevent-getcancelevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCancelEvent(out HANDLE phEvent);
}
