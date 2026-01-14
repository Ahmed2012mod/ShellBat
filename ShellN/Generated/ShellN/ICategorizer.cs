#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icategorizer
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a3b14589-9174-49a8-89a3-06a1ae2b9ba7")]
public partial interface ICategorizer
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icategorizer-getdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription([MarshalUsing(CountElementName = nameof(cch))] PWSTR pszDesc, uint cch);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icategorizer-getcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCategory(uint cidl, [In][Out][MarshalUsing(CountElementName = nameof(cidl))] nint[] apidl, [In][Out][MarshalUsing(CountElementName = nameof(cidl))] uint[] rgCategoryIds);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icategorizer-getcategoryinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCategoryInfo(uint dwCategoryId, out CATEGORY_INFO pci);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icategorizer-comparecategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompareCategory(CATSORT_FLAGS csfFlags, uint dwCategoryId1, uint dwCategoryId2);
}
