#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iexecutecommandhost
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("4b6832a2-5f04-4c9d-b89d-727a15d103e7")]
public partial interface IExecuteCommandHost
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexecutecommandhost-getuimode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUIMode(out EC_HOST_UI_MODE pUIMode);
}
