#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-dfmics
public partial struct DFMICS
{
    public uint cbSize;
    public uint fMask;
    public LPARAM lParam;
    public uint idCmdFirst;
    public uint idDefMax;
    public nint pici;
    public nint punkSite;
}
