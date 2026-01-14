#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-cabinetstate
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CABINETSTATE
{
    public ushort cLength;
    public ushort nVersion;
    public int _bitfield;
    public uint fMenuEnumFilter;
}
