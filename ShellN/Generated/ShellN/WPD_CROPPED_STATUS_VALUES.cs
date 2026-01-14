#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/wpd-cropped-status-values
public enum WPD_CROPPED_STATUS_VALUES
{
    WPD_CROPPED_STATUS_NOT_CROPPED = 0,
    WPD_CROPPED_STATUS_CROPPED = 1,
    WPD_CROPPED_STATUS_SHOULD_NOT_BE_CROPPED = 2,
}
