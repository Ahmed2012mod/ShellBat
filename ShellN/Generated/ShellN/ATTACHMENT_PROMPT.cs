#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-attachment_prompt
public enum ATTACHMENT_PROMPT
{
    ATTACHMENT_PROMPT_NONE = 0,
    ATTACHMENT_PROMPT_SAVE = 1,
    ATTACHMENT_PROMPT_EXEC = 2,
    ATTACHMENT_PROMPT_EXEC_OR_SAVE = 3,
}
