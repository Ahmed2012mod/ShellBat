#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_revocation_crl_info
public partial struct CERT_REVOCATION_CRL_INFO
{
    public uint cbSize;
    public nint pBaseCrlContext;
    public nint pDeltaCrlContext;
    public nint pCrlEntry;
    public BOOL fDeltaCrlEntry;
}
