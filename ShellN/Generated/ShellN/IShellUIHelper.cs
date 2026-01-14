#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("729fe2f8-1ea8-11d1-8f85-00c04fc2fbe1")]
public partial interface IShellUIHelper : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetFirstBootMode();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetSafeMode();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RefreshOfflineDesktop();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFavorite(BSTR URL, nint /* optional VARIANT* */ Title);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddChannel(BSTR URL);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDesktopComponent(BSTR URL, BSTR Type, nint /* optional VARIANT* */ Left, nint /* optional VARIANT* */ Top, nint /* optional VARIANT* */ Width, nint /* optional VARIANT* */ Height);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSubscribed(BSTR URL, out VARIANT_BOOL pBool);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NavigateAndFind(BSTR URL, BSTR strQuery, in VARIANT varTargetFrame);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ImportExportFavorites(VARIANT_BOOL fImport, BSTR strImpExpPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AutoCompleteSaveForm(nint /* optional VARIANT* */ Form);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AutoScan(BSTR strSearch, BSTR strFailureUrl, nint /* optional VARIANT* */ pvarTargetFrame);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AutoCompleteAttach(nint /* optional VARIANT* */ Reserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowBrowserUI(BSTR bstrName, in VARIANT pvarIn, out VARIANT pvarOut);
}
