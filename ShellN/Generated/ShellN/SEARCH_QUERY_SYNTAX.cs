#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/ne-searchapi-search_query_syntax
public enum SEARCH_QUERY_SYNTAX
{
    SEARCH_NO_QUERY_SYNTAX = 0,
    SEARCH_ADVANCED_QUERY_SYNTAX = 1,
    SEARCH_NATURAL_QUERY_SYNTAX = 2,
}
