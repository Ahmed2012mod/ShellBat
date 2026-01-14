#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-package_execution_state
public enum PACKAGE_EXECUTION_STATE
{
    PES_UNKNOWN = 0,
    PES_RUNNING = 1,
    PES_SUSPENDING = 2,
    PES_SUSPENDED = 3,
    PES_TERMINATED = 4,
}
