#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-shqueryrbinfo
public partial struct SHQUERYRBINFO
{
    public uint cbSize;
    public long i64Size;
    public long i64NumItems;
}
