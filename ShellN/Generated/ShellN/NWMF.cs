#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-nwmf
[Flags]
public enum NWMF
{
    NWMF_UNLOADING = 1,
    NWMF_USERINITED = 2,
    NWMF_FIRST = 4,
    NWMF_OVERRIDEKEY = 8,
    NWMF_SHOWHELP = 16,
    NWMF_HTMLDIALOG = 32,
    NWMF_FROMDIALOGCHILD = 64,
    NWMF_USERREQUESTED = 128,
    NWMF_USERALLOWED = 256,
    NWMF_FORCEWINDOW = 65536,
    NWMF_FORCETAB = 131072,
    NWMF_SUGGESTWINDOW = 262144,
    NWMF_SUGGESTTAB = 524288,
    NWMF_INACTIVETAB = 1048576,
}
