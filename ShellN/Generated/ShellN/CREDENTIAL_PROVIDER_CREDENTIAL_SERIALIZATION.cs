#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/ns-credentialprovider-credential_provider_credential_serialization
public partial struct CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION
{
    public uint ulAuthenticationPackage;
    public Guid clsidCredentialProvider;
    public uint cbSerialization;
    public nint rgbSerialization;
}
