#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-dropdescription
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DROPDESCRIPTION
{
    public DROPIMAGETYPE type;
    public InlineArraySystemChar_260 szMessage;
    public InlineArraySystemChar_260 szInsert;
}
