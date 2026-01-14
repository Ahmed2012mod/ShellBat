#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_svsif
public enum _SVSIF
{
    SVSI_DESELECT = 0,
    SVSI_SELECT = 1,
    SVSI_EDIT = 3,
    SVSI_DESELECTOTHERS = 4,
    SVSI_ENSUREVISIBLE = 8,
    SVSI_FOCUSED = 16,
    SVSI_TRANSLATEPT = 32,
    SVSI_SELECTIONMARK = 64,
    SVSI_POSITIONITEM = 128,
    SVSI_CHECK = 256,
    SVSI_CHECK2 = 512,
    SVSI_KEYBOARDSELECT = 1025,
    SVSI_NOTAKEFOCUS = 1073741824,
}
