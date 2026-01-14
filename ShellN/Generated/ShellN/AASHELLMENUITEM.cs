#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/ns-shlobj-aashellmenuitem
public partial struct AASHELLMENUITEM
{
    public nint lpReserved1;
    public int iReserved;
    public uint uiReserved;
    public nint lpName;
    public PWSTR psz;
}
