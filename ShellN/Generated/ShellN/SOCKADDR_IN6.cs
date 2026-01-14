#nullable enable
namespace ShellN;

public partial struct SOCKADDR_IN6
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint sin6_scope_id;
        
        [FieldOffset(0)]
        public SCOPE_ID sin6_scope_struct;
    }
    
    public ADDRESS_FAMILY sin6_family;
    public ushort sin6_port;
    public uint sin6_flowinfo;
    public IN6_ADDR sin6_addr;
    public _Anonymous_e__Union Anonymous;
}
