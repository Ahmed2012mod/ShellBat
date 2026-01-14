#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("18bcc359-4990-4bfb-b951-3c83702be5f9")]
public partial interface IWebWizardHost : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FinalBack();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FinalNext();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Caption(BSTR bstrCaption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Caption(out BSTR pbstrCaption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Property(BSTR bstrPropertyName, in VARIANT pvProperty);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Property(BSTR bstrPropertyName, out VARIANT pvProperty);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWizardButtons(VARIANT_BOOL vfEnableBack, VARIANT_BOOL vfEnableNext, VARIANT_BOOL vfLastPage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHeaderText(BSTR bstrHeaderTitle, BSTR bstrHeaderSubtitle);
}
