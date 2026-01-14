#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/ns-shlobj-sfv_setitempos
public partial struct SFV_SETITEMPOS
{
    public nint pidl;
    public POINT pt;
}
