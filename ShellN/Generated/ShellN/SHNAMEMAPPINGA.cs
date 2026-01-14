#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-shnamemappinga
public partial struct SHNAMEMAPPINGA
{
    public PSTR pszOldPath;
    public PSTR pszNewPath;
    public int cchOldPath;
    public int cchNewPath;
}
