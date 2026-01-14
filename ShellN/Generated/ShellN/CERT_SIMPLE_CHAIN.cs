#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_simple_chain
public partial struct CERT_SIMPLE_CHAIN
{
    public uint cbSize;
    public CERT_TRUST_STATUS TrustStatus;
    public uint cElement;
    public nint rgpElement;
    public nint pTrustListInfo;
    public BOOL fHasRevocationFreshnessTime;
    public uint dwRevocationFreshnessTime;
}
