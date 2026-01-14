#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ne-shobjidl_core-_kf_definition_flags
public enum _KF_DEFINITION_FLAGS
{
    KFDF_LOCAL_REDIRECT_ONLY = 2,
    KFDF_ROAMABLE = 4,
    KFDF_PRECREATE = 8,
    KFDF_STREAM = 16,
    KFDF_PUBLISHEXPANDEDPATH = 32,
    KFDF_NO_REDIRECT_UI = 64,
}
