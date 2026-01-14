#nullable enable
namespace ShellN;

public partial struct CMINVOKECOMMANDINFOEX_REMOTE
{
    public uint cbSize;
    public uint fMask;
    public HWND hwnd;
    public PSTR lpVerbString;
    public PSTR lpParameters;
    public PSTR lpDirectory;
    public int nShow;
    public uint dwHotKey;
    public PSTR lpTitle;
    public PWSTR lpVerbWString;
    public PWSTR lpParametersW;
    public PWSTR lpDirectoryW;
    public PWSTR lpTitleW;
    public POINT ptInvoke;
    public uint lpVerbInt;
    public uint lpVerbWInt;
}
