#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-cminvokecommandinfoex
public partial struct CMINVOKECOMMANDINFOEX
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
    public PSTR lpTitle;
    public PWSTR lpVerbW;
    public PWSTR lpParametersW;
    public PWSTR lpDirectoryW;
    public PWSTR lpTitleW;
    public POINT ptInvoke;
}
