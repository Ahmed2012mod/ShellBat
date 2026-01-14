#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winnetwk/ns-winnetwk-netresourcew
public partial struct NETRESOURCEW
{
    public NET_RESOURCE_SCOPE dwScope;
    public NET_RESOURCE_TYPE dwType;
    public uint dwDisplayType;
    public uint dwUsage;
    public PWSTR lpLocalName;
    public PWSTR lpRemoteName;
    public PWSTR lpComment;
    public PWSTR lpProvider;
}
