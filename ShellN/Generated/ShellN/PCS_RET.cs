#nullable enable
namespace ShellN;

[Flags]
public enum PCS_RET : uint
{
    PCS_FATAL = 2147483648,
    PCS_REPLACEDCHAR = 1,
    PCS_REMOVEDCHAR = 2,
    PCS_TRUNCATED = 4,
    PCS_PATHTOOLONG = 8,
}
