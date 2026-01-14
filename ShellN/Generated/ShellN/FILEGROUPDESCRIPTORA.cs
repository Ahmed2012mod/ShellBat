#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-filegroupdescriptora
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FILEGROUPDESCRIPTORA
{
    public uint cItems;
    public InlineArrayFILEDESCRIPTORA_1 fgd; // variable-length array placeholder
}
