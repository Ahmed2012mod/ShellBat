#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/urlmon/ns-urlmon-softdistinfo
public partial struct SOFTDISTINFO
{
    public uint cbSize;
    public uint dwFlags;
    public uint dwAdState;
    public PWSTR szTitle;
    public PWSTR szAbstract;
    public PWSTR szHREF;
    public uint dwInstalledVersionMS;
    public uint dwInstalledVersionLS;
    public uint dwUpdateVersionMS;
    public uint dwUpdateVersionLS;
    public uint dwAdvertisedVersionMS;
    public uint dwAdvertisedVersionLS;
    public uint dwReserved;
}
