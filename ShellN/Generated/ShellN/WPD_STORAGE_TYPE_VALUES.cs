#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/wpd-storage-type-values
public enum WPD_STORAGE_TYPE_VALUES
{
    WPD_STORAGE_TYPE_UNDEFINED = 0,
    WPD_STORAGE_TYPE_FIXED_ROM = 1,
    WPD_STORAGE_TYPE_REMOVABLE_ROM = 2,
    WPD_STORAGE_TYPE_FIXED_RAM = 3,
    WPD_STORAGE_TYPE_REMOVABLE_RAM = 4,
}
