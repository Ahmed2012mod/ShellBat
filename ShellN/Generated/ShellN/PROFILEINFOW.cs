#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/profinfo/ns-profinfo-profileinfow
public partial struct PROFILEINFOW
{
    public uint dwSize;
    public uint dwFlags;
    public PWSTR lpUserName;
    public PWSTR lpProfilePath;
    public PWSTR lpDefaultPath;
    public PWSTR lpServerName;
    public PWSTR lpPolicyPath;
    public HANDLE hProfile;
}
