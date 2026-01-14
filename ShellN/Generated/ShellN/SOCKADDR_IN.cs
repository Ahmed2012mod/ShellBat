#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winsock/ns-winsock-sockaddr_in
public partial struct SOCKADDR_IN
{
    public ADDRESS_FAMILY sin_family;
    public ushort sin_port;
    public IN_ADDR sin_addr;
    public InlineArrayCHAR_8 sin_zero;
}
