#nullable enable
namespace ShellN;

[Flags]
public enum FILE_SHARE_MODE : uint
{
    FILE_SHARE_NONE = 0,
    FILE_SHARE_DELETE = 4,
    FILE_SHARE_READ = 1,
    FILE_SHARE_WRITE = 2,
}
