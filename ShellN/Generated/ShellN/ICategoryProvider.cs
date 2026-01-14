#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icategoryprovider
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9af64809-5864-4c26-a720-c1f78c086ee3")]
public partial interface ICategoryProvider
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icategoryprovider-cancategorizeonscid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanCategorizeOnSCID(in PROPERTYKEY pscid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icategoryprovider-getdefaultcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultCategory(out Guid pguid, out PROPERTYKEY pscid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icategoryprovider-getcategoryforscid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCategoryForSCID(in PROPERTYKEY pscid, out Guid pguid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icategoryprovider-enumcategories
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumCategories([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumGUID>))] out IEnumGUID penum);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icategoryprovider-getcategoryname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCategoryName(in Guid pguid, [MarshalUsing(CountElementName = nameof(cch))] PWSTR pszName, uint cch);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icategoryprovider-createcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCategory(in Guid pguid, in Guid riid, out nint /* void */ ppv);
}
