#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("a7fe6eda-1932-4281-b881-87b31b8bc52c")]
public partial interface IShellUIHelper2 : IShellUIHelper
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSearchProvider(BSTR URL);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RunOnceShown();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SkipRunOnce();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CustomizeSettings(VARIANT_BOOL fSQM, VARIANT_BOOL fPhishing, BSTR bstrLocale);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SqmEnabled(out VARIANT_BOOL pfEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PhishingEnabled(out VARIANT_BOOL pfEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BrandImageUri(out BSTR pbstrUri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SkipTabsWelcome();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DiagnoseConnection();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CustomizeClearType(VARIANT_BOOL fSet);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSearchProviderInstalled(BSTR URL, out uint pdwResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSearchMigrated(out VARIANT_BOOL pfMigrated);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DefaultSearchProvider(out BSTR pbstrName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RunOnceRequiredSettingsComplete(VARIANT_BOOL fComplete);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RunOnceHasShown(out VARIANT_BOOL pfShown);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SearchGuideUrl(out BSTR pbstrUrl);
}
