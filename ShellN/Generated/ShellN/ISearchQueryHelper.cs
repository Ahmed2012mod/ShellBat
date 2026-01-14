#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-isearchqueryhelper
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ab310581-ac80-11d1-8df3-00c04fb6ef63")]
public partial interface ISearchQueryHelper
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-get_connectionstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ConnectionString(out PWSTR pszConnectionString);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-put_querycontentlocale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_QueryContentLocale(uint lcid);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-get_querycontentlocale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_QueryContentLocale(out uint plcid);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-put_querykeywordlocale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_QueryKeywordLocale(uint lcid);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-get_querykeywordlocale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_QueryKeywordLocale(out uint plcid);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-put_querytermexpansion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_QueryTermExpansion(SEARCH_TERM_EXPANSION expandTerms);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-get_querytermexpansion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_QueryTermExpansion(out SEARCH_TERM_EXPANSION pExpandTerms);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-put_querysyntax
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_QuerySyntax(SEARCH_QUERY_SYNTAX querySyntax);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-get_querysyntax
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_QuerySyntax(out SEARCH_QUERY_SYNTAX pQuerySyntax);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-put_querycontentproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_QueryContentProperties(PWSTR pszContentProperties);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-get_querycontentproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_QueryContentProperties(out PWSTR ppszContentProperties);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-put_queryselectcolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_QuerySelectColumns(PWSTR pszSelectColumns);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-get_queryselectcolumns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_QuerySelectColumns(out PWSTR ppszSelectColumns);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-put_querywhererestrictions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_QueryWhereRestrictions(PWSTR pszRestrictions);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-get_querywhererestrictions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_QueryWhereRestrictions(out PWSTR ppszRestrictions);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-put_querysorting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_QuerySorting(PWSTR pszSorting);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-get_querysorting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_QuerySorting(out PWSTR ppszSorting);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-generatesqlfromuserquery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateSQLFromUserQuery(PWSTR pszQuery, out PWSTR ppszSQL);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-writeproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteProperties(int itemID, uint dwNumberOfColumns, [In][MarshalUsing(CountElementName = nameof(dwNumberOfColumns))] PROPERTYKEY[] pColumns, [In][MarshalUsing(CountElementName = nameof(dwNumberOfColumns))] SEARCH_COLUMN_PROPERTIES[] pValues, in FILETIME pftGatherModifiedTime);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-put_querymaxresults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_QueryMaxResults(int cMaxResults);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-isearchqueryhelper-get_querymaxresults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_QueryMaxResults(out int pcMaxResults);
}
