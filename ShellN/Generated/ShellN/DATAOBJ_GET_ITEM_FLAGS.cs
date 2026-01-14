#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-dataobj_get_item_flags
[Flags]
public enum DATAOBJ_GET_ITEM_FLAGS
{
    DOGIF_DEFAULT = 0,
    DOGIF_TRAVERSE_LINK = 1,
    DOGIF_NO_HDROP = 2,
    DOGIF_NO_URL = 4,
    DOGIF_ONLY_IF_ONE = 8,
}
