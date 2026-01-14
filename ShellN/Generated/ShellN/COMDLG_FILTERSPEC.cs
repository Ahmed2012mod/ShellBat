#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-comdlg_filterspec
public partial struct COMDLG_FILTERSPEC
{
    public PWSTR pszName;
    public PWSTR pszSpec;
}
