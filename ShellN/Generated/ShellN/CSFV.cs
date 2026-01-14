#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-csfv
public partial struct CSFV
{
    public uint cbSize;
    public nint pshf;
    public nint psvOuter;
    public nint pidl;
    public int lEvents;
    public nint pfnCallback;
    public FOLDERVIEWMODE fvm;
}
