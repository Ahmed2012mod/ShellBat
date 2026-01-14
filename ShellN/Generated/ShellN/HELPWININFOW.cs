#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-helpwininfow
public partial struct HELPWININFOW
{
    public int wStructSize;
    public int x;
    public int y;
    public int dx;
    public int dy;
    public int wMax;
    public InlineArraySystemChar_2 rgchMember;
}
