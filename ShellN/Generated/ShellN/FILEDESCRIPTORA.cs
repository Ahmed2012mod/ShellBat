#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-filedescriptora
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FILEDESCRIPTORA
{
    public uint dwFlags;
    public Guid clsid;
    public SIZE sizel;
    public POINTL pointl;
    public uint dwFileAttributes;
    public FILETIME ftCreationTime;
    public FILETIME ftLastAccessTime;
    public FILETIME ftLastWriteTime;
    public uint nFileSizeHigh;
    public uint nFileSizeLow;
    public InlineArrayFoundationCHAR_260 cFileName;
}
