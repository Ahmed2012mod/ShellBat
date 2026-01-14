#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/wpd-capture-modes
public enum WPD_CAPTURE_MODES
{
    WPD_CAPTURE_MODE_UNDEFINED = 0,
    WPD_CAPTURE_MODE_NORMAL = 1,
    WPD_CAPTURE_MODE_BURST = 2,
    WPD_CAPTURE_MODE_TIMELAPSE = 3,
}
