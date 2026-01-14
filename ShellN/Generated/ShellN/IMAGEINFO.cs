#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/commctrl/ns-commctrl-imageinfo
public partial struct IMAGEINFO
{
    public HBITMAP hbmImage;
    public HBITMAP hbmMask;
    public int Unused1;
    public int Unused2;
    public RECT rcImage;
}
