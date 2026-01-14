#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/ns-shlobj-shchangeproductkeyasidlist
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHChangeProductKeyAsIDList
{
    public ushort cb;
    public InlineArrayChar_39 wszProductKey;
    public ushort cbZero;
}
