#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-crl_info
public partial struct CRL_INFO
{
    public uint dwVersion;
    public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;
    public CRYPT_INTEGER_BLOB Issuer;
    public FILETIME ThisUpdate;
    public FILETIME NextUpdate;
    public uint cCRLEntry;
    public nint rgCRLEntry;
    public uint cExtension;
    public nint rgExtension;
}
