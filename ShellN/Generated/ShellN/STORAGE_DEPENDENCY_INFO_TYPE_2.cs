#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/virtdisk/ns-virtdisk-storage_dependency_info_type_2
public partial struct STORAGE_DEPENDENCY_INFO_TYPE_2
{
    public DEPENDENT_DISK_FLAG DependencyTypeFlags;
    public uint ProviderSpecificFlags;
    public VIRTUAL_STORAGE_TYPE VirtualStorageType;
    public uint AncestorLevel;
    public PWSTR DependencyDeviceName;
    public PWSTR HostVolumeName;
    public PWSTR DependentVolumeName;
    public PWSTR DependentVolumeRelativePath;
}
