#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-file_usage_type
public enum FILE_USAGE_TYPE
{
    FUT_PLAYING = 0,
    FUT_EDITING = 1,
    FUT_GENERIC = 2,
}
