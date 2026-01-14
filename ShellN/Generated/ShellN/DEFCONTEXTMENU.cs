#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-defcontextmenu
public partial struct DEFCONTEXTMENU
{
    public HWND hwnd;
    public nint pcmcb;
    public nint pidlFolder;
    public nint psf;
    public uint cidl;
    public nint apidl;
    public nint punkAssociationInfo;
    public uint cKeys;
    public nint aKeys;
}
