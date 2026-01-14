#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/ns-shlobj-shcolumninfo
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHCOLUMNINFO
{
    public PROPERTYKEY scid;
    public VARENUM vt;
    public uint fmt;
    public uint cChars;
    public uint csFlags;
    public InlineArraySystemChar_80 wszTitle;
    public InlineArraySystemChar_128 wszDescription;
}
