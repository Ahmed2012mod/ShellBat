#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-shchangedwordasidlist
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHChangeDWORDAsIDList
{
    public ushort cb;
    public uint dwItem1;
    public uint dwItem2;
    public ushort cbZero;
}
