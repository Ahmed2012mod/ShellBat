#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-shfileinfow
public partial struct SHFILEINFOW
{
    public HICON hIcon;
    public int iIcon;
    public uint dwAttributes;
    public InlineArraySystemChar_260 szDisplayName;
    public InlineArraySystemChar_80 szTypeName;
}
