#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/cpl/ns-cpl-newcplinfoa
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NEWCPLINFOA
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwHelpContext;
    public nint lData;
    public HICON hIcon;
    public InlineArrayFoundationCHAR_32 szName;
    public InlineArrayFoundationCHAR_64 szInfo;
    public InlineArrayFoundationCHAR_128 szHelpFile;
}
