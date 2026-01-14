#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shldisp/ne-shldisp-shellfolderviewoptions
public enum ShellFolderViewOptions
{
    SFVVO_SHOWALLOBJECTS = 1,
    SFVVO_SHOWEXTENSIONS = 2,
    SFVVO_SHOWCOMPCOLOR = 8,
    SFVVO_SHOWSYSFILES = 32,
    SFVVO_WIN95CLASSIC = 64,
    SFVVO_DOUBLECLICKINWEBVIEW = 128,
    SFVVO_DESKTOPHTML = 512,
}
