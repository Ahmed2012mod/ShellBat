#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/credentialprovider/ns-credentialprovider-credential_provider_field_descriptor
public partial struct CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR
{
    public uint dwFieldID;
    public CREDENTIAL_PROVIDER_FIELD_TYPE cpft;
    public PWSTR pszLabel;
    public Guid guidFieldType;
}
