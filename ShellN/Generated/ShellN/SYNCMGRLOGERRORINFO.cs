#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/ns-mobsync-syncmgrlogerrorinfo
public partial struct SYNCMGRLOGERRORINFO
{
    public uint cbSize;
    public uint mask;
    public uint dwSyncMgrErrorFlags;
    public Guid ErrorID;
    public Guid ItemID;
}
