#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-shelldetails
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHELLDETAILS
{
    public int fmt;
    public int cxChar;
    public STRRET str;
}
