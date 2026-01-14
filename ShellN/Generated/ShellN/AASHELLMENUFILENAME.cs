#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/ns-shlobj-aashellmenufilename
public partial struct AASHELLMENUFILENAME
{
    public short cbTotal;
    public InlineArrayByte_12 rgbReserved;
    public InlineArraySystemChar_1 szFileName; // variable-length array placeholder
}
