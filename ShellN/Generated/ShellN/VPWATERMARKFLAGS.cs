#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/ne-shobjidl-vpwatermarkflags
[Flags]
public enum VPWATERMARKFLAGS
{
    VPWF_DEFAULT = 0,
    VPWF_ALPHABLEND = 1,
}
