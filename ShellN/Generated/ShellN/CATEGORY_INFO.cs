#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-category_info
public partial struct CATEGORY_INFO
{
    public CATEGORYINFO_FLAGS cif;
    public InlineArraySystemChar_260 wszName;
}
