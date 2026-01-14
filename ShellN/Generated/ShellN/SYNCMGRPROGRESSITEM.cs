#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/ns-mobsync-syncmgrprogressitem
public partial struct SYNCMGRPROGRESSITEM
{
    public uint cbSize;
    public uint mask;
    public PWSTR lpcStatusText;
    public uint dwStatusType;
    public int iProgValue;
    public int iMaxValue;
}
