#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-appbardata
public partial struct APPBARDATA
{
    public uint cbSize;
    public HWND hWnd;
    public uint uCallbackMessage;
    public uint uEdge;
    public RECT rc;
    public LPARAM lParam;
}
