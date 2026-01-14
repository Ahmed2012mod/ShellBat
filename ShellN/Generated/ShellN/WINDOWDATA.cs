#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/tlogstg/ns-tlogstg-windowdata
public partial struct WINDOWDATA
{
    public uint dwWindowID;
    public uint uiCP;
    public nint pidl;
    public PWSTR lpszUrl;
    public PWSTR lpszUrlLocation;
    public PWSTR lpszTitle;
}
