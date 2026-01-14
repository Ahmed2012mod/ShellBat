#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-stpflag
[Flags]
public enum STPFLAG
{
    STPF_NONE = 0,
    STPF_USEAPPTHUMBNAILALWAYS = 1,
    STPF_USEAPPTHUMBNAILWHENACTIVE = 2,
    STPF_USEAPPPEEKALWAYS = 4,
    STPF_USEAPPPEEKWHENACTIVE = 8,
}
