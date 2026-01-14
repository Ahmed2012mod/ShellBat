#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cmsg_signer_info
public partial struct CMSG_SIGNER_INFO
{
    public uint dwVersion;
    public CRYPT_INTEGER_BLOB Issuer;
    public CRYPT_INTEGER_BLOB SerialNumber;
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    public CRYPT_ALGORITHM_IDENTIFIER HashEncryptionAlgorithm;
    public CRYPT_INTEGER_BLOB EncryptedHash;
    public CRYPT_ATTRIBUTES AuthAttrs;
    public CRYPT_ATTRIBUTES UnauthAttrs;
}
