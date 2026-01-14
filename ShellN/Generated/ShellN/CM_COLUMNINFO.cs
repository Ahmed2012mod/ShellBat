#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-cm_columninfo
public partial struct CM_COLUMNINFO
{
    public uint cbSize;
    public uint dwMask;
    public uint dwState;
    public uint uWidth;
    public uint uDefaultWidth;
    public uint uIdealWidth;
    public InlineArraySystemChar_80 wszName;
}
