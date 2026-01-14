#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-monitor_app_visibility
public enum MONITOR_APP_VISIBILITY
{
    MAV_UNKNOWN = 0,
    MAV_NO_APP_VISIBLE = 1,
    MAV_APP_VISIBLE = 2,
}
