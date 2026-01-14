#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipropertysystem
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ca724e8a-c3e6-442b-88a4-6fb0db8035a3")]
public partial interface IPropertySystem
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertysystem-getpropertydescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyDescription(in PROPERTYKEY propkey, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertysystem-getpropertydescriptionbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyDescriptionByName(PWSTR pszCanonicalName, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertysystem-getpropertydescriptionlistfromstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyDescriptionListFromString(PWSTR pszPropList, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertysystem-enumeratepropertydescriptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumeratePropertyDescriptions(PROPDESC_ENUMFILTER filterOn, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertysystem-formatfordisplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FormatForDisplay(in PROPERTYKEY key, in PROPVARIANT propvar, PROPDESC_FORMAT_FLAGS pdff, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertysystem-formatfordisplayalloc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FormatForDisplayAlloc(in PROPERTYKEY key, in PROPVARIANT propvar, PROPDESC_FORMAT_FLAGS pdff, out PWSTR ppszDisplay);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertysystem-registerpropertyschema
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterPropertySchema(PWSTR pszPath);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertysystem-unregisterpropertyschema
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterPropertySchema(PWSTR pszPath);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipropertysystem-refreshpropertyschema
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RefreshPropertySchema();
}
