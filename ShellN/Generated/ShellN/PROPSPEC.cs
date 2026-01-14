#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propidlbase/ns-propidlbase-propspec
public partial struct PROPSPEC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint propid;
        
        [FieldOffset(0)]
        public PWSTR lpwstr;
    }
    
    public PROPSPEC_KIND ulKind;
    public _Anonymous_e__Union Anonymous;
}
