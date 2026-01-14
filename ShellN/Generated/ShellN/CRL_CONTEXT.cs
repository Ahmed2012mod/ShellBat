#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-crl_context
public partial struct CRL_CONTEXT
{
    public CERT_QUERY_ENCODING_TYPE dwCertEncodingType;
    public nint pbCrlEncoded;
    public uint cbCrlEncoded;
    public nint pCrlInfo;
    public HCERTSTORE hCertStore;
}
