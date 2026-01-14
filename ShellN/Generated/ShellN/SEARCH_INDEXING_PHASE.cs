#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/ne-searchapi-search_indexing_phase
public enum SEARCH_INDEXING_PHASE
{
    SEARCH_INDEXING_PHASE_GATHERER = 0,
    SEARCH_INDEXING_PHASE_QUERYABLE = 1,
    SEARCH_INDEXING_PHASE_PERSISTED = 2,
}
