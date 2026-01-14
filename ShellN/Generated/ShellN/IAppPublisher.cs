#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shappmgr/nn-shappmgr-iapppublisher
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("07250a10-9cf9-11d1-9076-006008059382")]
public partial interface IAppPublisher
{
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-iapppublisher-getnumberofcategories
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfCategories(out uint pdwCat);
    
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-iapppublisher-getcategories
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCategories(out APPCATEGORYINFOLIST pAppCategoryList);
    
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-iapppublisher-getnumberofapps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfApps(out uint pdwApps);
    
    // https://learn.microsoft.com/windows/win32/api/shappmgr/nf-shappmgr-iapppublisher-enumapps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumApps(in Guid pAppCategoryId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumPublishedApps>))] out IEnumPublishedApps ppepa);
}
