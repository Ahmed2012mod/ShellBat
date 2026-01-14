#nullable enable
namespace ShellN;

[Flags]
public enum NETINFOSTRUCT_CHARACTERISTICS : uint
{
    NETINFO_DLL16 = 1,
    NETINFO_DISKRED = 4,
    NETINFO_PRINTERRED = 8,
}
