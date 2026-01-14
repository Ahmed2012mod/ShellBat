#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-shfileinfoa
public partial struct SHFILEINFOA
{
    public HICON hIcon;
    public int iIcon;
    public uint dwAttributes;
    public InlineArrayFoundationCHAR_260 szDisplayName;
    public InlineArrayFoundationCHAR_80 szTypeName;
}
