#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/ns-shlobj-shcolumndata
public partial struct SHCOLUMNDATA
{
    public uint dwFlags;
    public uint dwFileAttributes;
    public uint dwReserved;
    public PWSTR pwszExt;
    public InlineArraySystemChar_260 wszFile;
}
