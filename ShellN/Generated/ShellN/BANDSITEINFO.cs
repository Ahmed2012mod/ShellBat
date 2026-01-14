#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-bandsiteinfo
public partial struct BANDSITEINFO
{
    public uint dwMask;
    public uint dwState;
    public uint dwStyle;
}
