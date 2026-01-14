#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-shchangenotifyentry
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHChangeNotifyEntry
{
    public nint pidl;
    public BOOL fRecursive;
}
