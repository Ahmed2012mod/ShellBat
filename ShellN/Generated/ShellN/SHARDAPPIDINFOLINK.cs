#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-shardappidinfolink
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHARDAPPIDINFOLINK
{
    public nint psl;
    public PWSTR pszAppID;
}
