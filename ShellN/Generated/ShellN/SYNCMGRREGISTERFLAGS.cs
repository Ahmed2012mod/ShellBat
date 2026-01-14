#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/ne-mobsync-syncmgrregisterflags
public enum SYNCMGRREGISTERFLAGS
{
    SYNCMGRREGISTERFLAG_CONNECT = 1,
    SYNCMGRREGISTERFLAG_PENDINGDISCONNECT = 2,
    SYNCMGRREGISTERFLAG_IDLE = 4,
}
