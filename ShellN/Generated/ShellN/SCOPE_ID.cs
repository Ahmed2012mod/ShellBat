#nullable enable
namespace ShellN;

public partial struct SCOPE_ID
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public uint _bitfield;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public uint Value;
    }
    
    public _Anonymous_e__Union Anonymous;
}
