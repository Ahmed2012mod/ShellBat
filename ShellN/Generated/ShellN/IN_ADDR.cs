#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/inaddr/ns-inaddr-in_addr
public partial struct IN_ADDR
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _S_un_e__Union
    {
        public struct _S_un_b_e__Struct
        {
            public byte s_b1;
            public byte s_b2;
            public byte s_b3;
            public byte s_b4;
        }
        
        public struct _S_un_w_e__Struct
        {
            public ushort s_w1;
            public ushort s_w2;
        }
        
        [FieldOffset(0)]
        public _S_un_b_e__Struct S_un_b;
        
        [FieldOffset(0)]
        public _S_un_w_e__Struct S_un_w;
        
        [FieldOffset(0)]
        public uint S_addr;
    }
    
    public _S_un_e__Union S_un;
}
