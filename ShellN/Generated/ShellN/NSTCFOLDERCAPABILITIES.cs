#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-nstcfoldercapabilities
[Flags]
public enum NSTCFOLDERCAPABILITIES
{
    NSTCFC_NONE = 0,
    NSTCFC_PINNEDITEMFILTERING = 1,
    NSTCFC_DELAY_REGISTER_NOTIFY = 2,
}
