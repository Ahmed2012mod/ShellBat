#nullable enable
namespace ShellN;

public partial struct INTERNET_SECURITY_INFO
{
    public uint dwSize;
    public nint pCertificate;
    public nint pcCertChain;
    public SecPkgContext_ConnectionInfo connectionInfo;
    public SecPkgContext_CipherInfo cipherInfo;
    public nint pcUnverifiedCertChain;
    public SecPkgContext_Bindings channelBindingToken;
}
