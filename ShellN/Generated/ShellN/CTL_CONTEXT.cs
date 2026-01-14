#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-ctl_context
public partial struct CTL_CONTEXT
{
    public uint dwMsgAndCertEncodingType;
    public nint pbCtlEncoded;
    public uint cbCtlEncoded;
    public nint pCtlInfo;
    public HCERTSTORE hCertStore;
    public nint hCryptMsg;
    public nint pbCtlContent;
    public uint cbCtlContent;
}
