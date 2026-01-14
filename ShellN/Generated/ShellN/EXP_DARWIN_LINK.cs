#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-exp_darwin_link
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EXP_DARWIN_LINK
{
    public DATABLOCK_HEADER dbh;
    public InlineArrayFoundationCHAR_260 szDarwinID;
    public InlineArraySystemChar_260 szwDarwinID;
}
