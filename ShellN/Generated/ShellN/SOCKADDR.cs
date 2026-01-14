#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winsock/ns-winsock-sockaddr
public partial struct SOCKADDR
{
    public ADDRESS_FAMILY sa_family;
    public InlineArrayCHAR_14 sa_data;
}
