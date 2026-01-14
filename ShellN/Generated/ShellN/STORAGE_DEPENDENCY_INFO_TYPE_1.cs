#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/virtdisk/ns-virtdisk-storage_dependency_info_type_1
public partial struct STORAGE_DEPENDENCY_INFO_TYPE_1
{
    public DEPENDENT_DISK_FLAG DependencyTypeFlags;
    public uint ProviderSpecificFlags;
    public VIRTUAL_STORAGE_TYPE VirtualStorageType;
}
