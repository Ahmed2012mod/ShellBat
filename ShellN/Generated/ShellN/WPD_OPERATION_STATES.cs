#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/wpd-operation-states
public enum WPD_OPERATION_STATES
{
    WPD_OPERATION_STATE_UNSPECIFIED = 0,
    WPD_OPERATION_STATE_STARTED = 1,
    WPD_OPERATION_STATE_RUNNING = 2,
    WPD_OPERATION_STATE_PAUSED = 3,
    WPD_OPERATION_STATE_CANCELLED = 4,
    WPD_OPERATION_STATE_FINISHED = 5,
    WPD_OPERATION_STATE_ABORTED = 6,
}
