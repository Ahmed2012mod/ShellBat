#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/ne-credentialprovider-credential_provider_field_interactive_state
public enum CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE
{
    CPFIS_NONE = 0,
    CPFIS_READONLY = 1,
    CPFIS_DISABLED = 2,
    CPFIS_FOCUSED = 3,
}
