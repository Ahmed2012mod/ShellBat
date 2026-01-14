#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-libraryoptionflags
[Flags]
public enum LIBRARYOPTIONFLAGS
{
    LOF_DEFAULT = 0,
    LOF_PINNEDTONAVPANE = 1,
    LOF_MASK_ALL = 1,
}
