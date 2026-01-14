#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-cminvokecommandinfo
public partial struct CMINVOKECOMMANDINFO
{
    public uint cbSize;
    public uint fMask;
    public HWND hwnd;
    public PSTR lpVerb;
    public PSTR lpParameters;
    public PSTR lpDirectory;
    public int nShow;
    public uint dwHotKey;
    public HANDLE hIcon;
}
