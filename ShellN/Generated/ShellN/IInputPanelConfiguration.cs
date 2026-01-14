#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/inputpanelconfiguration/nn-inputpanelconfiguration-iinputpanelconfiguration
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("41c81592-514c-48bd-a22e-e6af638521a6")]
public partial interface IInputPanelConfiguration
{
    // https://learn.microsoft.com/windows/win32/api/inputpanelconfiguration/nf-inputpanelconfiguration-iinputpanelconfiguration-enablefocustracking
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableFocusTracking();
}
