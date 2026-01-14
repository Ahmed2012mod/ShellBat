#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/virtdisk/ne-virtdisk-storage_dependency_info_version
public enum STORAGE_DEPENDENCY_INFO_VERSION
{
    STORAGE_DEPENDENCY_INFO_VERSION_UNSPECIFIED = 0,
    STORAGE_DEPENDENCY_INFO_VERSION_1 = 1,
    STORAGE_DEPENDENCY_INFO_VERSION_2 = 2,
}
