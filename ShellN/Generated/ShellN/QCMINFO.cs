#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-qcminfo
public partial struct QCMINFO
{
    public HMENU hmenu;
    public uint indexMenu;
    public uint idCmdFirst;
    public uint idCmdLast;
    public nint pIdMap;
}
