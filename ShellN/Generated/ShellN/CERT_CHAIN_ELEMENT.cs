#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_chain_element
public partial struct CERT_CHAIN_ELEMENT
{
    public uint cbSize;
    public nint pCertContext;
    public CERT_TRUST_STATUS TrustStatus;
    public nint pRevocationInfo;
    public nint pIssuanceUsage;
    public nint pApplicationUsage;
    public PWSTR pwszExtendedErrorInfo;
}
