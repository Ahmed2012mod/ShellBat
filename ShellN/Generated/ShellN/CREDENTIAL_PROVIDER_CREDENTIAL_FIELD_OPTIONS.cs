#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/ne-credentialprovider-credential_provider_credential_field_options
[Flags]
public enum CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS
{
    CPCFO_NONE = 0,
    CPCFO_ENABLE_PASSWORD_REVEAL = 1,
    CPCFO_IS_EMAIL_ADDRESS = 2,
    CPCFO_ENABLE_TOUCH_KEYBOARD_AUTO_INVOKE = 4,
    CPCFO_NUMBERS_ONLY = 8,
    CPCFO_SHOW_ENGLISH_KEYBOARD = 16,
}
