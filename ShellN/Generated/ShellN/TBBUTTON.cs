#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/commctrl/ns-commctrl-tbbutton
public partial struct TBBUTTON
{
    public int iBitmap;
    public int idCommand;
    public byte fsState;
    public byte fsStyle;
    public InlineArrayByte_6 bReserved;
    public nuint dwData;
    public nint iString;
}
