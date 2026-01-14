#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-shardappidinfo
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHARDAPPIDINFO
{
    public nint psi;
    public PWSTR pszAppID;
}
