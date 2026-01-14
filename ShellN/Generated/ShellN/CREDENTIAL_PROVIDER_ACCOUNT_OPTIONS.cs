#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/ne-credentialprovider-credential_provider_account_options
[Flags]
public enum CREDENTIAL_PROVIDER_ACCOUNT_OPTIONS
{
    CPAO_NONE = 0,
    CPAO_EMPTY_LOCAL = 1,
    CPAO_EMPTY_CONNECTED = 2,
}
