#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-thumbbuttonmask
[Flags]
public enum THUMBBUTTONMASK
{
    THB_BITMAP = 1,
    THB_ICON = 2,
    THB_TOOLTIP = 4,
    THB_FLAGS = 8,
}
