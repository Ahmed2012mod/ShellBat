#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/cpl/ns-cpl-cplinfo
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CPLINFO
{
    public int idIcon;
    public int idName;
    public int idInfo;
    public nint lData;
}
