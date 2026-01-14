#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/ns-shlobj-shcolumninit
public partial struct SHCOLUMNINIT
{
    public uint dwFlags;
    public uint dwReserved;
    public InlineArraySystemChar_260 wszFolder;
}
