#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-fde_shareviolation_response
public enum FDE_SHAREVIOLATION_RESPONSE
{
    FDESVR_DEFAULT = 0,
    FDESVR_ACCEPT = 1,
    FDESVR_REFUSE = 2,
}
