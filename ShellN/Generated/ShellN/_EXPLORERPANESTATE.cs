#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_explorerpanestate
public enum _EXPLORERPANESTATE
{
    EPS_DONTCARE = 0,
    EPS_DEFAULT_ON = 1,
    EPS_DEFAULT_OFF = 2,
    EPS_STATEMASK = 65535,
    EPS_INITIALSTATE = 65536,
    EPS_FORCE = 131072,
}
