#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-exp_special_folder
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EXP_SPECIAL_FOLDER
{
    public uint cbSize;
    public uint dwSignature;
    public uint idSpecialFolder;
    public uint cbOffset;
}
