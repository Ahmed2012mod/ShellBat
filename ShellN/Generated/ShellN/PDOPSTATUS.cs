#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-pdopstatus
public enum PDOPSTATUS
{
    PDOPS_RUNNING = 1,
    PDOPS_PAUSED = 2,
    PDOPS_CANCELLED = 3,
    PDOPS_STOPPED = 4,
    PDOPS_ERRORS = 5,
}
