#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-multikeyhelpw
public partial struct MULTIKEYHELPW
{
    public uint mkSize;
    public char mkKeylist;
    public InlineArraySystemChar_1 szKeyphrase; // variable-length array placeholder
}
