#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-strret
public partial struct STRRET
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public PWSTR pOleStr;
        
        [FieldOffset(0)]
        public uint uOffset;
        
        [FieldOffset(0)]
        public InlineArrayByte_260 cStr;
    }
    
    public uint uType;
    public _Anonymous_e__Union Anonymous;
}
