#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-openasinfo
public partial struct OPENASINFO
{
    public PWSTR pcszFile;
    public PWSTR pcszClass;
    public OPEN_AS_INFO_FLAGS oaifInFlags;
}
