#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-helpinfo
public partial struct HELPINFO
{
    public uint cbSize;
    public HELP_INFO_TYPE iContextType;
    public int iCtrlId;
    public HANDLE hItemHandle;
    public nuint dwContextId;
    public POINT MousePos;
}
