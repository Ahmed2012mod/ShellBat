#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/ne-credentialprovider-credential_provider_status_icon
public enum CREDENTIAL_PROVIDER_STATUS_ICON
{
    CPSI_NONE = 0,
    CPSI_ERROR = 1,
    CPSI_WARNING = 2,
    CPSI_SUCCESS = 3,
}
