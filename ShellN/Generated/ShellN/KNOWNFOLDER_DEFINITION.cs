#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-knownfolder_definition
public partial struct KNOWNFOLDER_DEFINITION
{
    public KF_CATEGORY category;
    public PWSTR pszName;
    public PWSTR pszDescription;
    public Guid fidParent;
    public PWSTR pszRelativePath;
    public PWSTR pszParsingName;
    public PWSTR pszTooltip;
    public PWSTR pszLocalizedName;
    public PWSTR pszIcon;
    public PWSTR pszSecurity;
    public uint dwAttributes;
    public uint kfdFlags;
    public Guid ftidType;
}
