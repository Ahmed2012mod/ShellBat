#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-shfileopstructa
public partial struct SHFILEOPSTRUCTA
{
    public HWND hwnd;
    public uint wFunc;
    public nint pFrom;
    public nint pTo;
    public ushort fFlags;
    public BOOL fAnyOperationsAborted;
    public nint hNameMappings;
    public PSTR lpszProgressTitle;
}
