#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-deskbandinfo
public partial struct DESKBANDINFO
{
    public uint dwMask;
    public POINTL ptMinSize;
    public POINTL ptMaxSize;
    public POINTL ptIntegral;
    public POINTL ptActual;
    public InlineArraySystemChar_256 wszTitle;
    public uint dwModeFlags;
    public COLORREF crBkgnd;
}
