#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-associationlevel
public enum ASSOCIATIONLEVEL
{
    AL_MACHINE = 0,
    AL_EFFECTIVE = 1,
    AL_USER = 2,
}
