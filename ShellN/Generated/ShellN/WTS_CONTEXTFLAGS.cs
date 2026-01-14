#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/thumbcache/ne-thumbcache-wts_contextflags
[Flags]
public enum WTS_CONTEXTFLAGS
{
    WTSCF_DEFAULT = 0,
    WTSCF_APPSTYLE = 1,
    WTSCF_SQUARE = 2,
    WTSCF_WIDE = 4,
    WTSCF_FAST = 8,
}
