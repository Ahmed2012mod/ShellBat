#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-crypt_decode_para
public partial struct CRYPT_DECODE_PARA
{
    public uint cbSize;
    public nint pfnAlloc;
    public nint pfnFree;
}
