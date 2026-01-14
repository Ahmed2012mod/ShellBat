#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/ne-credentialprovider-credential_provider_get_serialization_response
public enum CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE
{
    CPGSR_NO_CREDENTIAL_NOT_FINISHED = 0,
    CPGSR_NO_CREDENTIAL_FINISHED = 1,
    CPGSR_RETURN_CREDENTIAL_FINISHED = 2,
    CPGSR_RETURN_NO_CREDENTIAL_FINISHED = 3,
}
