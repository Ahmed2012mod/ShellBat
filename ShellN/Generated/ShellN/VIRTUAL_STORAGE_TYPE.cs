#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/virtdisk/ns-virtdisk-virtual_storage_type
public partial struct VIRTUAL_STORAGE_TYPE
{
    public uint DeviceId;
    public Guid VendorId;
}
