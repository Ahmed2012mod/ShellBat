#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/ne-credentialprovider-credential_provider_field_type
public enum CREDENTIAL_PROVIDER_FIELD_TYPE
{
    CPFT_INVALID = 0,
    CPFT_LARGE_TEXT = 1,
    CPFT_SMALL_TEXT = 2,
    CPFT_COMMAND_LINK = 3,
    CPFT_EDIT_TEXT = 4,
    CPFT_PASSWORD_TEXT = 5,
    CPFT_TILE_IMAGE = 6,
    CPFT_CHECKBOX = 7,
    CPFT_COMBOBOX = 8,
    CPFT_SUBMIT_BUTTON = 9,
}
