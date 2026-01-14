#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-application_view_state
public enum APPLICATION_VIEW_STATE
{
    AVS_FULLSCREEN_LANDSCAPE = 0,
    AVS_FILLED = 1,
    AVS_SNAPPED = 2,
    AVS_FULLSCREEN_PORTRAIT = 3,
}
