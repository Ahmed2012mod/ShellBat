#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-crypt_attributes
public partial struct CRYPT_ATTRIBUTES
{
    public uint cAttr;
    public nint rgAttr;
}
