#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/schannel/ns-schannel-secpkgcontext_connectioninfo
public partial struct SecPkgContext_ConnectionInfo
{
    public uint dwProtocol;
    public ALG_ID aiCipher;
    public uint dwCipherStrength;
    public ALG_ID aiHash;
    public uint dwHashStrength;
    public ALG_ID aiExch;
    public uint dwExchStrength;
}
