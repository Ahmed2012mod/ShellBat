#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_nstcitemstate
public enum _NSTCITEMSTATE
{
    NSTCIS_NONE = 0,
    NSTCIS_SELECTED = 1,
    NSTCIS_EXPANDED = 2,
    NSTCIS_BOLD = 4,
    NSTCIS_DISABLED = 8,
    NSTCIS_SELECTEDNOEXPAND = 16,
}
