#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/virtdisk/ns-virtdisk-storage_dependency_info
public partial struct STORAGE_DEPENDENCY_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public InlineArraySTORAGE_DEPENDENCY_INFO_TYPE_1_1 Version1Entries;
        
        [FieldOffset(0)]
        public InlineArraySTORAGE_DEPENDENCY_INFO_TYPE_2_1 Version2Entries;
    }
    
    public STORAGE_DEPENDENCY_INFO_VERSION Version;
    public uint NumberEntries;
    public _Anonymous_e__Union Anonymous;
}
