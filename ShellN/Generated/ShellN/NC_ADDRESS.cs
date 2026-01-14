#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-nc_address
public partial struct NC_ADDRESS
{
    public nint pAddrInfo;
    public ushort PortNumber;
    public byte PrefixLength;
}
