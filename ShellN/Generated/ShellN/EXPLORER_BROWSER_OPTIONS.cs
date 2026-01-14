#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-explorer_browser_options
[Flags]
public enum EXPLORER_BROWSER_OPTIONS
{
    EBO_NONE = 0,
    EBO_NAVIGATEONCE = 1,
    EBO_SHOWFRAMES = 2,
    EBO_ALWAYSNAVIGATE = 4,
    EBO_NOTRAVELLOG = 8,
    EBO_NOWRAPPERWINDOW = 16,
    EBO_HTMLSHAREPOINTVIEW = 32,
    EBO_NOBORDER = 64,
    EBO_NOPERSISTVIEWSTATE = 128,
}
