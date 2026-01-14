#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/ns-shdeprecated-toolbaritem
public partial struct TOOLBARITEM
{
    public nint ptbar;
    public RECT rcBorderTool;
    public PWSTR pwszItem;
    public BOOL fShow;
    public HMONITOR hMon;
}
