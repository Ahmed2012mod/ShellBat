#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-shardappidinfoidlist
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHARDAPPIDINFOIDLIST
{
    public nint pidl;
    public PWSTR pszAppID;
}
