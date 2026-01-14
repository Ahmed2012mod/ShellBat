#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/ns-shlobj-bandinfosfb
public partial struct BANDINFOSFB
{
    public uint dwMask;
    public uint dwStateMask;
    public uint dwState;
    public COLORREF crBkgnd;
    public COLORREF crBtnLt;
    public COLORREF crBtnDk;
    public ushort wViewMode;
    public ushort wAlign;
    public nint psf;
    public nint pidl;
}
