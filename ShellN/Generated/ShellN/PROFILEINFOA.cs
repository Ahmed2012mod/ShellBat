#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/profinfo/ns-profinfo-profileinfoa
public partial struct PROFILEINFOA
{
    public uint dwSize;
    public uint dwFlags;
    public PSTR lpUserName;
    public PSTR lpProfilePath;
    public PSTR lpDefaultPath;
    public PSTR lpServerName;
    public PSTR lpPolicyPath;
    public HANDLE hProfile;
}
