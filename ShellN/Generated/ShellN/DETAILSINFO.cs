#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-detailsinfo
public partial struct DETAILSINFO
{
    public nint pidl;
    public int fmt;
    public int cxChar;
    public STRRET str;
    public int iImage;
}
