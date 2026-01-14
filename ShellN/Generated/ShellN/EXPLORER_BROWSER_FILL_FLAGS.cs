#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-explorer_browser_fill_flags
[Flags]
public enum EXPLORER_BROWSER_FILL_FLAGS
{
    EBF_NONE = 0,
    EBF_SELECTFROMDATAOBJECT = 256,
    EBF_NODROPTARGET = 512,
}
