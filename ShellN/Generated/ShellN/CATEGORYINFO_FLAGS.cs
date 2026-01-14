#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-categoryinfo_flags
[Flags]
public enum CATEGORYINFO_FLAGS
{
    CATINFO_NORMAL = 0,
    CATINFO_COLLAPSED = 1,
    CATINFO_HIDDEN = 2,
    CATINFO_EXPANDED = 4,
    CATINFO_NOHEADER = 8,
    CATINFO_NOTCOLLAPSIBLE = 16,
    CATINFO_NOHEADERCOUNT = 32,
    CATINFO_SUBSETTED = 64,
    CATINFO_SEPARATE_IMAGES = 128,
    CATINFO_SHOWEMPTY = 256,
}
