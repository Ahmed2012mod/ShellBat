#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/wpd-stream-units
public enum WPD_STREAM_UNITS
{
    WPD_STREAM_UNITS_BYTES = 0,
    WPD_STREAM_UNITS_FRAMES = 1,
    WPD_STREAM_UNITS_ROWS = 2,
    WPD_STREAM_UNITS_MILLISECONDS = 4,
    WPD_STREAM_UNITS_MICROSECONDS = 8,
}
