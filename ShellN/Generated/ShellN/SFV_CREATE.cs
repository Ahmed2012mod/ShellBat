#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-sfv_create
public partial struct SFV_CREATE
{
    public uint cbSize;
    public nint pshf;
    public nint psvOuter;
    public nint psfvcb;
}
