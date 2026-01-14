#nullable enable
namespace ShellN;

[Flags]
public enum NET_RESOURCE_TYPE : uint
{
    RESOURCETYPE_ANY = 0,
    RESOURCETYPE_DISK = 1,
    RESOURCETYPE_PRINT = 2,
}
