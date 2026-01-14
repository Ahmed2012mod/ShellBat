#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-application_view_size_preference
public enum APPLICATION_VIEW_SIZE_PREFERENCE
{
    AVSP_DEFAULT = 0,
    AVSP_USE_LESS = 1,
    AVSP_USE_HALF = 2,
    AVSP_USE_MORE = 3,
    AVSP_USE_MINIMUM = 4,
    AVSP_USE_NONE = 5,
    AVSP_CUSTOM = 6,
}
