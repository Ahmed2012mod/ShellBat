#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/cpl/ns-cpl-newcplinfow
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NEWCPLINFOW
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwHelpContext;
    public nint lData;
    public HICON hIcon;
    public InlineArraySystemChar_32 szName;
    public InlineArraySystemChar_64 szInfo;
    public InlineArraySystemChar_128 szHelpFile;
}
