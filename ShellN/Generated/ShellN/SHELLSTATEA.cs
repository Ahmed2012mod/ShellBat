#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-shellstatea
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHELLSTATEA
{
    public int _bitfield1;
    public uint dwWin95Unused;
    public uint uWin95Unused;
    public int lParamSort;
    public int iSortDirection;
    public uint version;
    public uint uNotUsed;
    public int _bitfield2;
}
