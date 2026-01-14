#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ne-ocidl-readystate
public enum READYSTATE
{
    READYSTATE_UNINITIALIZED = 0,
    READYSTATE_LOADING = 1,
    READYSTATE_LOADED = 2,
    READYSTATE_INTERACTIVE = 3,
    READYSTATE_COMPLETE = 4,
}
