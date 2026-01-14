#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-datablock_header
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DATABLOCK_HEADER
{
    public uint cbSize;
    public uint dwSignature;
}
