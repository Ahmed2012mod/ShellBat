#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iwizardsite
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("88960f5b-422f-4e7b-8013-73415381c3c3")]
public partial interface IWizardSite
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iwizardsite-getpreviouspage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreviousPage(out HPROPSHEETPAGE phpage);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iwizardsite-getnextpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextPage(out HPROPSHEETPAGE phpage);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iwizardsite-getcancelledpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCancelledPage(out HPROPSHEETPAGE phpage);
}
