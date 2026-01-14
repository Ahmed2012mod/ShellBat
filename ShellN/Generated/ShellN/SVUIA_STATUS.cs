#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-svuia_status
public enum SVUIA_STATUS
{
    SVUIA_DEACTIVATE = 0,
    SVUIA_ACTIVATE_NOFOCUS = 1,
    SVUIA_ACTIVATE_FOCUS = 2,
    SVUIA_INPLACEACTIVATE = 3,
}
