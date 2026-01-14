#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_spbeginf
public enum _SPBEGINF
{
    SPBEGINF_NORMAL = 0,
    SPBEGINF_AUTOTIME = 2,
    SPBEGINF_NOPROGRESSBAR = 16,
    SPBEGINF_MARQUEEPROGRESS = 32,
    SPBEGINF_NOCANCELBUTTON = 64,
}
