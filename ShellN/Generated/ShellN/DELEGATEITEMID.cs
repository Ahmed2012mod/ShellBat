#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-delegateitemid
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DELEGATEITEMID
{
    public ushort cbSize;
    public ushort wOuter;
    public ushort cbInner;
    public InlineArrayByte_1 rgb; // variable-length array placeholder
}
