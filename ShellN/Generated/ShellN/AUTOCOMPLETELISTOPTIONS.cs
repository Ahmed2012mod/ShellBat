#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ne-shlobj_core-autocompletelistoptions
public enum AUTOCOMPLETELISTOPTIONS
{
    ACLO_NONE = 0,
    ACLO_CURRENTDIR = 1,
    ACLO_MYCOMPUTER = 2,
    ACLO_DESKTOP = 4,
    ACLO_FAVORITES = 8,
    ACLO_FILESYSONLY = 16,
    ACLO_FILESYSDIRS = 32,
    ACLO_VIRTUALNAMESPACE = 64,
}
