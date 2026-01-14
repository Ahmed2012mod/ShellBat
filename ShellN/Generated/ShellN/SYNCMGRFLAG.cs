#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/ne-mobsync-syncmgrflag
public enum SYNCMGRFLAG
{
    SYNCMGRFLAG_CONNECT = 1,
    SYNCMGRFLAG_PENDINGDISCONNECT = 2,
    SYNCMGRFLAG_MANUAL = 3,
    SYNCMGRFLAG_IDLE = 4,
    SYNCMGRFLAG_INVOKE = 5,
    SYNCMGRFLAG_SCHEDULED = 6,
    SYNCMGRFLAG_EVENTMASK = 255,
    SYNCMGRFLAG_SETTINGS = 256,
    SYNCMGRFLAG_MAYBOTHERUSER = 512,
}
