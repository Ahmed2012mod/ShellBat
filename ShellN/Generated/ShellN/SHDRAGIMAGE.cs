#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-shdragimage
public partial struct SHDRAGIMAGE
{
    public SIZE sizeDragImage;
    public POINT ptOffset;
    public HBITMAP hbmpDragImage;
    public COLORREF crColorKey;
}
