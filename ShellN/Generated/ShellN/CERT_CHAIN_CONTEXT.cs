#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_chain_context
public partial struct CERT_CHAIN_CONTEXT
{
    public uint cbSize;
    public CERT_TRUST_STATUS TrustStatus;
    public uint cChain;
    public nint rgpChain;
    public uint cLowerQualityChainContext;
    public nint rgpLowerQualityChainContext;
    public BOOL fHasRevocationFreshnessTime;
    public uint dwRevocationFreshnessTime;
    public uint dwCreateFlags;
    public Guid ChainId;
}
