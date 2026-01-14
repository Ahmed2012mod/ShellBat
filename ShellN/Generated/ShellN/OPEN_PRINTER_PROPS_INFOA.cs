#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-open_printer_props_infoa
public partial struct OPEN_PRINTER_PROPS_INFOA
{
    public uint dwSize;
    public PSTR pszSheetName;
    public uint uSheetIndex;
    public uint dwFlags;
    public BOOL bModal;
}
