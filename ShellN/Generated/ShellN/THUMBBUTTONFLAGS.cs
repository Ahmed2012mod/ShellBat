#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-thumbbuttonflags
[Flags]
public enum THUMBBUTTONFLAGS
{
    THBF_ENABLED = 0,
    THBF_DISABLED = 1,
    THBF_DISMISSONCLICK = 2,
    THBF_NOBACKGROUND = 4,
    THBF_HIDDEN = 8,
    THBF_NONINTERACTIVE = 16,
}
