#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/ne-credentialprovider-credential_provider_field_state
public enum CREDENTIAL_PROVIDER_FIELD_STATE
{
    CPFS_HIDDEN = 0,
    CPFS_DISPLAY_IN_SELECTED_TILE = 1,
    CPFS_DISPLAY_IN_DESELECTED_TILE = 2,
    CPFS_DISPLAY_IN_BOTH = 3,
}
