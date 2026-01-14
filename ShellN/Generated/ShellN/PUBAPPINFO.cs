#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shappmgr/ns-shappmgr-pubappinfo
public partial struct PUBAPPINFO
{
    public uint cbSize;
    public uint dwMask;
    public PWSTR pszSource;
    public SYSTEMTIME stAssigned;
    public SYSTEMTIME stPublished;
    public SYSTEMTIME stScheduled;
    public SYSTEMTIME stExpire;
}
