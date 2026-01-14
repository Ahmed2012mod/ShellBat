#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/wpd_sdk/wpd-device-types
public enum WPD_DEVICE_TYPES
{
    WPD_DEVICE_TYPE_GENERIC = 0,
    WPD_DEVICE_TYPE_CAMERA = 1,
    WPD_DEVICE_TYPE_MEDIA_PLAYER = 2,
    WPD_DEVICE_TYPE_PHONE = 3,
    WPD_DEVICE_TYPE_VIDEO = 4,
    WPD_DEVICE_TYPE_PERSONAL_INFORMATION_MANAGER = 5,
    WPD_DEVICE_TYPE_AUDIO_RECORDER = 6,
}
