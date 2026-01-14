#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-librarymanagedialogoptions
[Flags]
public enum LIBRARYMANAGEDIALOGOPTIONS
{
    LMD_DEFAULT = 0,
    LMD_ALLOWUNINDEXABLENETWORKLOCATIONS = 1,
}
