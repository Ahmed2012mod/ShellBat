#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-propprg
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct PROPPRG
{
    public ushort flPrg;
    public ushort flPrgInit;
    public InlineArrayCHAR_30 achTitle;
    public InlineArrayFoundationCHAR_128 achCmdLine;
    public InlineArrayFoundationCHAR_64 achWorkDir;
    public ushort wHotKey;
    public InlineArrayFoundationCHAR_80 achIconFile;
    public ushort wIconIndex;
    public uint dwEnhModeFlags;
    public uint dwRealModeFlags;
    public InlineArrayFoundationCHAR_80 achOtherFile;
    public InlineArrayFoundationCHAR_260 achPIFFile;
}
