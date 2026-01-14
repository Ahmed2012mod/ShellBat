#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iwebwizardextension
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("0e6b3f66-98d1-48c0-a222-fbde74e2fbc5")]
public partial interface IWebWizardExtension : IWizardExtension
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iwebwizardextension-setinitialurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInitialURL(PWSTR pszURL);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iwebwizardextension-seterrorurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetErrorURL(PWSTR pszErrorURL);
}
