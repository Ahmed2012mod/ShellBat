#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shappmgr/ns-shappmgr-slowappinfo
public partial struct SLOWAPPINFO
{
    public ulong ullSize;
    public FILETIME ftLastUsed;
    public int iTimesUsed;
    public PWSTR pszImage;
}
