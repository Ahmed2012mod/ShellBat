#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-multikeyhelpa
public partial struct MULTIKEYHELPA
{
    public uint mkSize;
    public CHAR mkKeylist;
    public InlineArrayFoundationCHAR_1 szKeyphrase; // variable-length array placeholder
}
