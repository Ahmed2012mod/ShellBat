#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-librarysaveflags
[Flags]
public enum LIBRARYSAVEFLAGS
{
    LSF_FAILIFTHERE = 0,
    LSF_OVERRIDEEXISTING = 1,
    LSF_MAKEUNIQUENAME = 2,
}
