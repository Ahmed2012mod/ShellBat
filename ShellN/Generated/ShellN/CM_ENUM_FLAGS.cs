#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-cm_enum_flags
[Flags]
public enum CM_ENUM_FLAGS
{
    CM_ENUM_ALL = 1,
    CM_ENUM_VISIBLE = 2,
}
