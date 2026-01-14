#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-cert_trust_list_info
public partial struct CERT_TRUST_LIST_INFO
{
    public uint cbSize;
    public nint pCtlEntry;
    public nint pCtlContext;
}
