#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-open_printer_props_infow
public partial struct OPEN_PRINTER_PROPS_INFOW
{
    public uint dwSize;
    public PWSTR pszSheetName;
    public uint uSheetIndex;
    public uint dwFlags;
    public BOOL bModal;
}
