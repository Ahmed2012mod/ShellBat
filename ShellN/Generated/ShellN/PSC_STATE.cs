#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-psc_state
public enum PSC_STATE
{
    PSC_NORMAL = 0,
    PSC_NOTINSOURCE = 1,
    PSC_DIRTY = 2,
    PSC_READONLY = 3,
}
