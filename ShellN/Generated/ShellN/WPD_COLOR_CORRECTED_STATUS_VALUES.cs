#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/wpd-color-corrected-status-values
public enum WPD_COLOR_CORRECTED_STATUS_VALUES
{
    WPD_COLOR_CORRECTED_STATUS_NOT_CORRECTED = 0,
    WPD_COLOR_CORRECTED_STATUS_CORRECTED = 1,
    WPD_COLOR_CORRECTED_STATUS_SHOULD_NOT_BE_CORRECTED = 2,
}
