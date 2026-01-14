#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("528df2ec-d419-40bc-9b6d-dcdbf9c1b25d")]
public partial interface IShellUIHelper3 : IShellUIHelper2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddService(BSTR URL);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsServiceInstalled(BSTR URL, BSTR Verb, out uint pdwResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InPrivateFilteringEnabled(out VARIANT_BOOL pfEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddToFavoritesBar(BSTR URL, BSTR Title, in VARIANT Type);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BuildNewTabPage();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRecentlyClosedVisible(VARIANT_BOOL fVisible);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActivitiesVisible(VARIANT_BOOL fVisible);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ContentDiscoveryReset();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSuggestedSitesEnabled(out VARIANT_BOOL pfEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableSuggestedSites(VARIANT_BOOL fEnable);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NavigateToSuggestedSites(BSTR bstrRelativeUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowTabsHelp();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowInPrivateHelp();
}
