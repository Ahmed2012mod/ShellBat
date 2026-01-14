#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-thumbbutton
public partial struct THUMBBUTTON
{
    public THUMBBUTTONMASK dwMask;
    public uint iId;
    public uint iBitmap;
    public HICON hIcon;
    public InlineArraySystemChar_260 szTip;
    public THUMBBUTTONFLAGS dwFlags;
}
