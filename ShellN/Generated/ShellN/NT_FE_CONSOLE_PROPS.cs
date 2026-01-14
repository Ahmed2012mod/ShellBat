#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-nt_fe_console_props
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NT_FE_CONSOLE_PROPS
{
    public DATABLOCK_HEADER dbh;
    public uint uCodePage;
}
