#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/commctrl/ns-commctrl-imagelistdrawparams
public partial struct IMAGELISTDRAWPARAMS
{
    public uint cbSize;
    public HIMAGELIST himl;
    public int i;
    public HDC hdcDst;
    public int x;
    public int y;
    public int cx;
    public int cy;
    public int xBitmap;
    public int yBitmap;
    public COLORREF rgbBk;
    public COLORREF rgbFg;
    public uint fStyle;
    public uint dwRop;
    public uint fState;
    public uint Frame;
    public COLORREF crEffect;
}
