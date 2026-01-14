#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlwapi/ne-shlwapi-assockey
public enum ASSOCKEY
{
    ASSOCKEY_SHELLEXECCLASS = 1,
    ASSOCKEY_APP = 2,
    ASSOCKEY_CLASS = 3,
    ASSOCKEY_BASECLASS = 4,
    ASSOCKEY_MAX = 5,
}
