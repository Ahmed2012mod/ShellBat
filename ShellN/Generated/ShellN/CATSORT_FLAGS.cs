#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-catsort_flags
[Flags]
public enum CATSORT_FLAGS
{
    CATSORT_DEFAULT = 0,
    CATSORT_NAME = 1,
}
