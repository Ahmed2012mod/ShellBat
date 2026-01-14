#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellscalingapi/ne-shellscalingapi-scale_change_flags
[Flags]
public enum SCALE_CHANGE_FLAGS
{
    SCF_VALUE_NONE = 0,
    SCF_SCALE = 1,
    SCF_PHYSICAL = 2,
}
