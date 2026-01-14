#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_expcmdstate
[Flags]
public enum _EXPCMDSTATE
{
    ECS_ENABLED = 0,
    ECS_DISABLED = 1,
    ECS_HIDDEN = 2,
    ECS_CHECKBOX = 4,
    ECS_CHECKED = 8,
    ECS_RADIOCHECK = 16,
}
