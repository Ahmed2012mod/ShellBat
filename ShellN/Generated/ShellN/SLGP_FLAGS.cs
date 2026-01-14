#nullable enable
namespace ShellN;

[Flags]
public enum SLGP_FLAGS
{
    SLGP_SHORTPATH = 1,
    SLGP_UNCPRIORITY = 2,
    SLGP_RAWPATH = 4,
    SLGP_RELATIVEPRIORITY = 8,
}
