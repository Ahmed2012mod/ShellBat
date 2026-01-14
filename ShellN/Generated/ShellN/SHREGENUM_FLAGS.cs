#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlwapi/ne-shlwapi-shregenum_flags
public enum SHREGENUM_FLAGS
{
    SHREGENUM_DEFAULT = 0,
    SHREGENUM_HKCU = 1,
    SHREGENUM_HKLM = 16,
    SHREGENUM_BOTH = 17,
}
