#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-pka_flags
[Flags]
public enum PKA_FLAGS
{
    PKA_SET = 0,
    PKA_APPEND = 1,
    PKA_DELETE = 2,
}
