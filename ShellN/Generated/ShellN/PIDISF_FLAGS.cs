#nullable enable
namespace ShellN;

[Flags]
public enum PIDISF_FLAGS
{
    PIDISF_RECENTLYCHANGED = 1,
    PIDISF_CACHEDSTICKY = 2,
    PIDISF_CACHEIMAGES = 16,
    PIDISF_FOLLOWALLLINKS = 32,
}
