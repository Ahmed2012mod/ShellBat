#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/ne-searchapi-catalogstatus
public enum CatalogStatus
{
    CATALOG_STATUS_IDLE = 0,
    CATALOG_STATUS_PAUSED = 1,
    CATALOG_STATUS_RECOVERING = 2,
    CATALOG_STATUS_FULL_CRAWL = 3,
    CATALOG_STATUS_INCREMENTAL_CRAWL = 4,
    CATALOG_STATUS_PROCESSING_NOTIFICATIONS = 5,
    CATALOG_STATUS_SHUTTING_DOWN = 6,
}
