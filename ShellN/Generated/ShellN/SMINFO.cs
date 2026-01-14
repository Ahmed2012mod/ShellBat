#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-sminfo
public partial struct SMINFO
{
    public uint dwMask;
    public uint dwType;
    public uint dwFlags;
    public int iIcon;
}
