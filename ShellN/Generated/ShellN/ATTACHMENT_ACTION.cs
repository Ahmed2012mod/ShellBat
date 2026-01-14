#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-attachment_action
public enum ATTACHMENT_ACTION
{
    ATTACHMENT_ACTION_CANCEL = 0,
    ATTACHMENT_ACTION_SAVE = 1,
    ATTACHMENT_ACTION_EXEC = 2,
}
