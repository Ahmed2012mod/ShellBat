#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlwapi/ns-shlwapi-parsedurlw
public partial struct PARSEDURLW
{
    public uint cbSize;
    public PWSTR pszProtocol;
    public uint cchProtocol;
    public PWSTR pszSuffix;
    public uint cchSuffix;
    public uint nScheme;
}
