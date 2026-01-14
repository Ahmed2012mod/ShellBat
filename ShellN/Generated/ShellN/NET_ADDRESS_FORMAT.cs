#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/iphlpapi/ne-iphlpapi-net_address_format
public enum NET_ADDRESS_FORMAT
{
    NET_ADDRESS_FORMAT_UNSPECIFIED = 0,
    NET_ADDRESS_DNS_NAME = 1,
    NET_ADDRESS_IPV4 = 2,
    NET_ADDRESS_IPV6 = 3,
}
