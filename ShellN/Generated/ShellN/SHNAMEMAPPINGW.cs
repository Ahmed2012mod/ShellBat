#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-shnamemappingw
public partial struct SHNAMEMAPPINGW
{
    public PWSTR pszOldPath;
    public PWSTR pszNewPath;
    public int cchOldPath;
    public int cchNewPath;
}
