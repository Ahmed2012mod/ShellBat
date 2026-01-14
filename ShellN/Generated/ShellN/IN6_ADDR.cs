#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/in6addr/ns-in6addr-in6_addr
public partial struct IN6_ADDR
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _u_e__Union
    {
        [FieldOffset(0)]
        public InlineArrayByte_16 Byte;
        
        [FieldOffset(0)]
        public InlineArrayUInt16_8 Word;
    }
    
    public _u_e__Union u;
}
