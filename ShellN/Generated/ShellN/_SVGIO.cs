#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_svgio
[Flags]
public enum _SVGIO
{
    SVGIO_BACKGROUND = 0,
    SVGIO_SELECTION = 1,
    SVGIO_ALLVIEW = 2,
    SVGIO_CHECKED = 3,
    SVGIO_TYPE_MASK = 15,
    SVGIO_FLAG_VIEWORDER = int.MinValue,
}
