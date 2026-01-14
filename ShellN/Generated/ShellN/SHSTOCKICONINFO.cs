#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-shstockiconinfo
public partial struct SHSTOCKICONINFO
{
    public uint cbSize;
    public HICON hIcon;
    public int iSysImageIndex;
    public int iIcon;
    public InlineArraySystemChar_260 szPath;
}
