#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-sortcolumn
public partial struct SORTCOLUMN
{
    public PROPERTYKEY propkey;
    public SORTDIRECTION direction;
}
