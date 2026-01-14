#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-shchangeupdateimageidlist
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHChangeUpdateImageIDList
{
    public ushort cb;
    public int iIconIndex;
    public int iCurIndex;
    public uint uFlags;
    public uint dwProcessID;
    public InlineArraySystemChar_260 szName;
    public ushort cbZero;
}
