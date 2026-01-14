#nullable enable
namespace ShellN;

public partial struct SPC_LINK
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public PWSTR pwszUrl;
        
        [FieldOffset(0)]
        public SPC_SERIALIZED_OBJECT Moniker;
        
        [FieldOffset(0)]
        public PWSTR pwszFile;
    }
    
    public uint dwLinkChoice;
    public _Anonymous_e__Union Anonymous;
}
