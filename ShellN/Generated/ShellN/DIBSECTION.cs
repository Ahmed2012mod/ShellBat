#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-dibsection
public partial struct DIBSECTION
{
    public BITMAP dsBm;
    public BITMAPINFOHEADER dsBmih;
    public InlineArrayUInt32_3 dsBitfields;
    public HANDLE dshSection;
    public uint dsOffset;
}
