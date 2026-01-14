#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-cm_state
[Flags]
public enum CM_STATE
{
    CM_STATE_NONE = 0,
    CM_STATE_VISIBLE = 1,
    CM_STATE_FIXEDWIDTH = 2,
    CM_STATE_NOSORTBYFOLDERNESS = 4,
    CM_STATE_ALWAYSVISIBLE = 8,
}
