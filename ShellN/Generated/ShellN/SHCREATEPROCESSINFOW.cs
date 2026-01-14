#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-shcreateprocessinfow
public partial struct SHCREATEPROCESSINFOW
{
    public uint cbSize;
    public uint fMask;
    public HWND hwnd;
    public PWSTR pszFile;
    public PWSTR pszParameters;
    public PWSTR pszCurrentDirectory;
    public HANDLE hUserToken;
    public nint lpProcessAttributes;
    public nint lpThreadAttributes;
    public BOOL bInheritHandles;
    public uint dwCreationFlags;
    public nint lpStartupInfo;
    public nint lpProcessInformation;
}
