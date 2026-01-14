#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_revocation_info
public partial struct CERT_REVOCATION_INFO
{
    public uint cbSize;
    public uint dwRevocationResult;
    public PSTR pszRevocationOid;
    public nint pvOidSpecificInfo;
    public BOOL fHasFreshnessTime;
    public uint dwFreshnessTime;
    public nint pCrlInfo;
}
