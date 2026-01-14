#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-sync_transfer_status
[Flags]
public enum SYNC_TRANSFER_STATUS
{
    STS_NONE = 0,
    STS_NEEDSUPLOAD = 1,
    STS_NEEDSDOWNLOAD = 2,
    STS_TRANSFERRING = 4,
    STS_PAUSED = 8,
    STS_HASERROR = 16,
    STS_FETCHING_METADATA = 32,
    STS_USER_REQUESTED_REFRESH = 64,
    STS_HASWARNING = 128,
    STS_EXCLUDED = 256,
    STS_INCOMPLETE = 512,
    STS_PLACEHOLDER_IFEMPTY = 1024,
}
