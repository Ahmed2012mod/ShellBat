#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-helpwininfoa
public partial struct HELPWININFOA
{
    public int wStructSize;
    public int x;
    public int y;
    public int dx;
    public int dy;
    public int wMax;
    public InlineArrayFoundationCHAR_2 rgchMember;
}
