#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/inputpanelconfiguration/nn-inputpanelconfiguration-iinputpanelinvocationconfiguration
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a213f136-3b45-4362-a332-efb6547cd432")]
public partial interface IInputPanelInvocationConfiguration
{
    // https://learn.microsoft.com/windows/win32/api/inputpanelconfiguration/nf-inputpanelconfiguration-iinputpanelinvocationconfiguration-requiretouchineditcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequireTouchInEditControl();
}
