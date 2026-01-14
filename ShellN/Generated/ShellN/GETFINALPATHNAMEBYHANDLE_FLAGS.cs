#nullable enable
namespace ShellN;

public enum GETFINALPATHNAMEBYHANDLE_FLAGS : uint
{
    VOLUME_NAME_DOS = 0,
    VOLUME_NAME_GUID = 1,
    VOLUME_NAME_NT = 2,
    VOLUME_NAME_NONE = 4,
    FILE_NAME_NORMALIZED = 0,
    FILE_NAME_OPENED = 8,
}
