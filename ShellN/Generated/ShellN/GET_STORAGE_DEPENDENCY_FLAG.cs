#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/virtdisk/ne-virtdisk-get_storage_dependency_flag
[Flags]
public enum GET_STORAGE_DEPENDENCY_FLAG
{
    GET_STORAGE_DEPENDENCY_FLAG_NONE = 0,
    GET_STORAGE_DEPENDENCY_FLAG_HOST_VOLUMES = 1,
    GET_STORAGE_DEPENDENCY_FLAG_DISK_HANDLE = 2,
}
