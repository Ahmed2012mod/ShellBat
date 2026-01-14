#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/iphlpapi/ns-iphlpapi-net_address_info
public partial struct NET_ADDRESS_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _NamedAddress_e__Struct
        {
            public InlineArraySystemChar_256 Address;
            public InlineArrayChar_6 Port;
        }
        
        [FieldOffset(0)]
        public _NamedAddress_e__Struct NamedAddress;
        
        [FieldOffset(0)]
        public SOCKADDR_IN Ipv4Address;
        
        [FieldOffset(0)]
        public SOCKADDR_IN6 Ipv6Address;
        
        [FieldOffset(0)]
        public SOCKADDR IpAddress;
    }
    
    public NET_ADDRESS_FORMAT Format;
    public _Anonymous_e__Union Anonymous;
}
