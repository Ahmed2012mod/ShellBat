#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iexecutecommandapplicationhostenvironment
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("18b21aa9-e184-4ff0-9f5e-f882d03771b3")]
public partial interface IExecuteCommandApplicationHostEnvironment
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexecutecommandapplicationhostenvironment-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(out AHE_TYPE pahe);
}
