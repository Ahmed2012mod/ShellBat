#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-shfileopstructw
public partial struct SHFILEOPSTRUCTW
{
    public HWND hwnd;
    public uint wFunc;
    public PWSTR pFrom;
    public PWSTR pTo;
    public ushort fFlags;
    public BOOL fAnyOperationsAborted;
    public nint hNameMappings;
    public PWSTR lpszProgressTitle;
}
