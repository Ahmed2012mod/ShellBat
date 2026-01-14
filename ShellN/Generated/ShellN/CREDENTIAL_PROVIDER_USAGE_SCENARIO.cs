#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/ne-credentialprovider-credential_provider_usage_scenario
public enum CREDENTIAL_PROVIDER_USAGE_SCENARIO
{
    CPUS_INVALID = 0,
    CPUS_LOGON = 1,
    CPUS_UNLOCK_WORKSTATION = 2,
    CPUS_CHANGE_PASSWORD = 3,
    CPUS_CREDUI = 4,
    CPUS_PLAP = 5,
}
