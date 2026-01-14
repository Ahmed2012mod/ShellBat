#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-cm_mask
[Flags]
public enum CM_MASK
{
    CM_MASK_WIDTH = 1,
    CM_MASK_DEFAULTWIDTH = 2,
    CM_MASK_IDEALWIDTH = 4,
    CM_MASK_NAME = 8,
    CM_MASK_STATE = 16,
}
