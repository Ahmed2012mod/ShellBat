#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlwapi/ne-shlwapi-shregdel_flags
public enum SHREGDEL_FLAGS
{
    SHREGDEL_DEFAULT = 0,
    SHREGDEL_HKCU = 1,
    SHREGDEL_HKLM = 16,
    SHREGDEL_BOTH = 17,
}
