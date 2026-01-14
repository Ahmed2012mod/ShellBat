#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ne-shlobj_core-ieshortcutflags
public enum IESHORTCUTFLAGS
{
    IESHORTCUT_NEWBROWSER = 1,
    IESHORTCUT_OPENNEWTAB = 2,
    IESHORTCUT_FORCENAVIGATE = 4,
    IESHORTCUT_BACKGROUNDTAB = 8,
}
