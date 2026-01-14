#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-exp_sz_link
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EXP_SZ_LINK
{
    public uint cbSize;
    public uint dwSignature;
    public InlineArrayFoundationCHAR_260 szTarget;
    public InlineArraySystemChar_260 swzTarget;
}
