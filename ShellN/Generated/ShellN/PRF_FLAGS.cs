#nullable enable
namespace ShellN;

[Flags]
public enum PRF_FLAGS
{
    PRF_VERIFYEXISTS = 1,
    PRF_TRYPROGRAMEXTENSIONS = 3,
    PRF_FIRSTDIRDEF = 4,
    PRF_DONTFINDLNK = 8,
    PRF_REQUIREABSOLUTE = 16,
}
