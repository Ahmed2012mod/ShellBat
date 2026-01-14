#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/exdisp/ne-exdisp-shellwindowfindwindowoptions
public enum ShellWindowFindWindowOptions
{
    SWFO_NEEDDISPATCH = 1,
    SWFO_INCLUDEPENDING = 2,
    SWFO_COOKIEPASSED = 4,
}
