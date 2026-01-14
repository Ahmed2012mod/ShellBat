#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/ne-shobjidl-nstcstyle2
[Flags]
public enum NSTCSTYLE2
{
    NSTCS2_DEFAULT = 0,
    NSTCS2_INTERRUPTNOTIFICATIONS = 1,
    NSTCS2_SHOWNULLSPACEMENU = 2,
    NSTCS2_DISPLAYPADDING = 4,
    NSTCS2_DISPLAYPINNEDONLY = 8,
    NTSCS2_NOSINGLETONAUTOEXPAND = 16,
    NTSCS2_NEVERINSERTNONENUMERATED = 32,
}
