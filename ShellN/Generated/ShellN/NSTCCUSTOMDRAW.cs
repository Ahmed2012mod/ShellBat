#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/ns-shobjidl-nstccustomdraw
public partial struct NSTCCUSTOMDRAW
{
    public nint psi;
    public uint uItemState;
    public uint nstcis;
    public PWSTR pszText;
    public int iImage;
    public HIMAGELIST himl;
    public int iLevel;
    public int iIndent;
}
