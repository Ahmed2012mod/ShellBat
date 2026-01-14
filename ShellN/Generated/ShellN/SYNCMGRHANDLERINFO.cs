#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/ns-mobsync-syncmgrhandlerinfo
public partial struct SYNCMGRHANDLERINFO
{
    public uint cbSize;
    public HICON hIcon;
    public uint SyncMgrHandlerFlags;
    public InlineArraySystemChar_32 wszHandlerName;
}
