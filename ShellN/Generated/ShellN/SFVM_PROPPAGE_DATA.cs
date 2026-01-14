#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-sfvm_proppage_data
public partial struct SFVM_PROPPAGE_DATA
{
    public uint dwReserved;
    public nint pfn;
    public LPARAM lParam;
}
