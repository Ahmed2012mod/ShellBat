#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-createstructw
public partial struct CREATESTRUCTW
{
    public nint lpCreateParams;
    public HINSTANCE hInstance;
    public HMENU hMenu;
    public HWND hwndParent;
    public int cy;
    public int cx;
    public int y;
    public int x;
    public int style;
    public PWSTR lpszName;
    public PWSTR lpszClass;
    public WINDOW_EX_STYLE dwExStyle;
}
