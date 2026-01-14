#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winnetwk/ns-winnetwk-netresourcea
public partial struct NETRESOURCEA
{
    public NET_RESOURCE_SCOPE dwScope;
    public NET_RESOURCE_TYPE dwType;
    public uint dwDisplayType;
    public uint dwUsage;
    public PSTR lpLocalName;
    public PSTR lpRemoteName;
    public PSTR lpComment;
    public PSTR lpProvider;
}
