#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/schannel/ns-schannel-secpkgcontext_cipherinfo
public partial struct SecPkgContext_CipherInfo
{
    public uint dwVersion;
    public uint dwProtocol;
    public uint dwCipherSuite;
    public uint dwBaseCipherSuite;
    public InlineArraySystemChar_64 szCipherSuite;
    public InlineArraySystemChar_64 szCipher;
    public uint dwCipherLen;
    public uint dwCipherBlockLen;
    public InlineArraySystemChar_64 szHash;
    public uint dwHashLen;
    public InlineArraySystemChar_64 szExchange;
    public uint dwMinExchangeLen;
    public uint dwMaxExchangeLen;
    public InlineArraySystemChar_64 szCertificate;
    public uint dwKeyType;
}
