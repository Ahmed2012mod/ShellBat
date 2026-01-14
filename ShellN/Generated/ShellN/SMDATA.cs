#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-smdata
public partial struct SMDATA
{
    public uint dwMask;
    public uint dwFlags;
    public HMENU hmenu;
    public HWND hwnd;
    public uint uId;
    public uint uIdParent;
    public uint uIdAncestor;
    public nint punk;
    public nint pidlFolder;
    public nint pidlItem;
    public nint psf;
    public nint pvUserData;
}
