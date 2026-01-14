#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_trust_status
public partial struct CERT_TRUST_STATUS
{
    public uint dwErrorStatus;
    public uint dwInfoStatus;
}
