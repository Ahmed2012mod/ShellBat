#nullable enable
namespace ShellN;

public partial struct DBBINDING
{
    public nuint iOrdinal;
    public nuint obValue;
    public nuint obLength;
    public nuint obStatus;
    public nint pTypeInfo;
    public nint pObject;
    public nint pBindExt;
    public uint dwPart;
    public uint dwMemOwner;
    public uint eParamIO;
    public nuint cbMaxLen;
    public uint dwFlags;
    public ushort wType;
    public byte bPrecision;
    public byte bScale;
}
