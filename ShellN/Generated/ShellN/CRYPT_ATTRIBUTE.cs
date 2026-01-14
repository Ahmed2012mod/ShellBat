#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-crypt_attribute
public partial struct CRYPT_ATTRIBUTE
{
    public PSTR pszObjId;
    public uint cValue;
    public nint rgValue;
}
