#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-ctl_entry
public partial struct CTL_ENTRY
{
    public CRYPT_INTEGER_BLOB SubjectIdentifier;
    public uint cAttribute;
    public nint rgAttribute;
}
