#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/exdisp/ne-exdisp-shellwindowtypeconstants
public enum ShellWindowTypeConstants
{
    SWC_EXPLORER = 0,
    SWC_BROWSER = 1,
    SWC_3RDPARTY = 2,
    SWC_CALLBACK = 4,
    SWC_DESKTOP = 8,
}
