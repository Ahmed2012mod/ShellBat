#nullable enable
namespace ShellN;

public enum HLID_INFO : uint
{
    HLID_INVALID = 0,
    HLID_PREVIOUS = uint.MaxValue,
    HLID_NEXT = 4294967294,
    HLID_CURRENT = 4294967293,
    HLID_STACKBOTTOM = 4294967292,
    HLID_STACKTOP = 4294967291,
}
