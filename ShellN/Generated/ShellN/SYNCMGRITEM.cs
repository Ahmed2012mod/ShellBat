#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/ns-mobsync-syncmgritem
public partial struct SYNCMGRITEM
{
    public uint cbSize;
    public uint dwFlags;
    public Guid ItemID;
    public uint dwItemState;
    public HICON hIcon;
    public InlineArraySystemChar_128 wszItemName;
    public FILETIME ftLastUpdate;
}
