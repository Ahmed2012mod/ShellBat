#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/appmgmt/ns-appmgmt-appcategoryinfo
public partial struct APPCATEGORYINFO
{
    public uint Locale;
    public PWSTR pszDescription;
    public Guid AppCategoryId;
}
