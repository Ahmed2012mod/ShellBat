#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-crl_entry
public partial struct CRL_ENTRY
{
    public CRYPT_INTEGER_BLOB SerialNumber;
    public FILETIME RevocationDate;
    public uint cExtension;
    public nint rgExtension;
}
