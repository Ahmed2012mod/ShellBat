#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/ne-shobjidl-folderviewoptions
[Flags]
public enum FOLDERVIEWOPTIONS
{
    FVO_DEFAULT = 0,
    FVO_VISTALAYOUT = 1,
    FVO_CUSTOMPOSITION = 2,
    FVO_CUSTOMORDERING = 4,
    FVO_SUPPORTHYPERLINKS = 8,
    FVO_NOANIMATIONS = 16,
    FVO_NOSCROLLTIPS = 32,
}
