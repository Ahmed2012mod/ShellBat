#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/ne-mobsync-syncmgrhandlerflags
public enum SYNCMGRHANDLERFLAGS
{
    SYNCMGRHANDLER_HASPROPERTIES = 1,
    SYNCMGRHANDLER_MAYESTABLISHCONNECTION = 2,
    SYNCMGRHANDLER_ALWAYSLISTHANDLER = 4,
    SYNCMGRHANDLER_HIDDEN = 8,
}
