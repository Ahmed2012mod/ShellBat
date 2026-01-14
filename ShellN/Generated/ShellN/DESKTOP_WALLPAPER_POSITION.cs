#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-desktop_wallpaper_position
public enum DESKTOP_WALLPAPER_POSITION
{
    DWPOS_CENTER = 0,
    DWPOS_TILE = 1,
    DWPOS_STRETCH = 2,
    DWPOS_FIT = 3,
    DWPOS_FILL = 4,
    DWPOS_SPAN = 5,
}
