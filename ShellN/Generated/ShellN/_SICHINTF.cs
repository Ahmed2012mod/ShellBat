#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_sichintf
public enum _SICHINTF
{
    SICHINT_DISPLAY = 0,
    SICHINT_ALLFIELDS = int.MinValue,
    SICHINT_CANONICAL = 268435456,
    SICHINT_TEST_FILESYSPATH_IF_NOT_EQUAL = 536870912,
}
