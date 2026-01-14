#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/ns-syncmgr-syncmgr_conflict_id_info
public partial struct SYNCMGR_CONFLICT_ID_INFO
{
    public nint pblobID;
    public nint pblobExtra;
}
