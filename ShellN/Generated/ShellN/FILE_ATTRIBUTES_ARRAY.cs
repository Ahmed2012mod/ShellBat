#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-file_attributes_array
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FILE_ATTRIBUTES_ARRAY
{
    public uint cItems;
    public uint dwSumFileAttributes;
    public uint dwProductFileAttributes;
    public InlineArrayUInt32_1 rgdwFileAttributes; // variable-length array placeholder
}
