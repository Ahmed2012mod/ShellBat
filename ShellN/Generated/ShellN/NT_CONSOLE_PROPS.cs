#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-nt_console_props
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NT_CONSOLE_PROPS
{
    public DATABLOCK_HEADER dbh;
    public ushort wFillAttribute;
    public ushort wPopupFillAttribute;
    public COORD dwScreenBufferSize;
    public COORD dwWindowSize;
    public COORD dwWindowOrigin;
    public uint nFont;
    public uint nInputBufferSize;
    public COORD dwFontSize;
    public uint uFontFamily;
    public uint uFontWeight;
    public InlineArraySystemChar_32 FaceName;
    public uint uCursorSize;
    public BOOL bFullScreen;
    public BOOL bQuickEdit;
    public BOOL bInsertMode;
    public BOOL bAutoPosition;
    public uint uHistoryBufferSize;
    public uint uNumberOfHistoryBuffers;
    public BOOL bHistoryNoDup;
    public InlineArrayCOLORREF_16 ColorTable;
}
