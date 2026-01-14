#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlwapi/ne-shlwapi-assocdata
public enum ASSOCDATA
{
    ASSOCDATA_MSIDESCRIPTOR = 1,
    ASSOCDATA_NOACTIVATEHANDLER = 2,
    ASSOCDATA_UNUSED1 = 3,
    ASSOCDATA_HASPERUSERASSOC = 4,
    ASSOCDATA_EDITFLAGS = 5,
    ASSOCDATA_VALUE = 6,
    ASSOCDATA_MAX = 7,
}
