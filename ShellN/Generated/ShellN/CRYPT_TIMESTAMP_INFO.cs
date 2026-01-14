#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-crypt_timestamp_info
public partial struct CRYPT_TIMESTAMP_INFO
{
    public uint dwVersion;
    public PSTR pszTSAPolicyId;
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    public CRYPT_INTEGER_BLOB HashedMessage;
    public CRYPT_INTEGER_BLOB SerialNumber;
    public FILETIME ftTime;
    public nint pvAccuracy;
    public BOOL fOrdering;
    public CRYPT_INTEGER_BLOB Nonce;
    public CRYPT_INTEGER_BLOB Tsa;
    public uint cExtension;
    public nint rgExtension;
}
