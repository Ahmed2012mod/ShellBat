#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlwapi/ns-shlwapi-parsedurla
public partial struct PARSEDURLA
{
    public uint cbSize;
    public PSTR pszProtocol;
    public uint cchProtocol;
    public PSTR pszSuffix;
    public uint cchSuffix;
    public uint nScheme;
}
