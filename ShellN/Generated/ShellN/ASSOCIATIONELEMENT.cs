#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-associationelement
public partial struct ASSOCIATIONELEMENT
{
    public ASSOCCLASS ac;
    public HKEY hkClass;
    public PWSTR pszClass;
}
