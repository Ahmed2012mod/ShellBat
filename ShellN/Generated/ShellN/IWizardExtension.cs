#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iwizardextension
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c02ea696-86cc-491e-9b23-74394a0444a8")]
public partial interface IWizardExtension
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iwizardextension-addpages
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPages([In][Out][MarshalUsing(CountElementName = nameof(cPages))] HPROPSHEETPAGE[] aPages, uint cPages, out uint pnPagesAdded);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iwizardextension-getfirstpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFirstPage(out HPROPSHEETPAGE phpage);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iwizardextension-getlastpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastPage(out HPROPSHEETPAGE phpage);
}
