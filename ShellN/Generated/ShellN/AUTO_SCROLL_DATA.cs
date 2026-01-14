#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-auto_scroll_data
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct AUTO_SCROLL_DATA
{
    public int iNextSample;
    public uint dwLastScroll;
    public BOOL bFull;
    public InlineArrayPOINT_3 pts;
    public InlineArrayUInt32_3 dwTimes;
}
