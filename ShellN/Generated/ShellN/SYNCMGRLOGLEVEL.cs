#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/ne-mobsync-syncmgrloglevel
public enum SYNCMGRLOGLEVEL
{
    SYNCMGRLOGLEVEL_INFORMATION = 1,
    SYNCMGRLOGLEVEL_WARNING = 2,
    SYNCMGRLOGLEVEL_ERROR = 3,
    SYNCMGRLOGLEVEL_LOGLEVELMAX = 3,
}
