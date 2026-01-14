#nullable enable
namespace ShellN;

[Flags]
public enum VALIDATEUNC_OPTION
{
    VALIDATEUNC_CONNECT = 1,
    VALIDATEUNC_NOUI = 2,
    VALIDATEUNC_PRINT = 4,
    VALIDATEUNC_PERSIST = 8,
    VALIDATEUNC_VALID = 15,
}
