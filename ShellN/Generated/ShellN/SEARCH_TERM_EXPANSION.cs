#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/ne-searchapi-search_term_expansion
public enum SEARCH_TERM_EXPANSION
{
    SEARCH_TERM_NO_EXPANSION = 0,
    SEARCH_TERM_PREFIX_ALL = 1,
    SEARCH_TERM_STEM_ALL = 2,
}
