#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-exp_propertystorage
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EXP_PROPERTYSTORAGE
{
    public uint cbSize;
    public uint dwSignature;
    public InlineArrayByte_1 abPropertyStorage; // variable-length array placeholder
}
