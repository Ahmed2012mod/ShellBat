#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/wpd-device-transports
public enum WPD_DEVICE_TRANSPORTS
{
    WPD_DEVICE_TRANSPORT_UNSPECIFIED = 0,
    WPD_DEVICE_TRANSPORT_USB = 1,
    WPD_DEVICE_TRANSPORT_IP = 2,
    WPD_DEVICE_TRANSPORT_BLUETOOTH = 3,
}
