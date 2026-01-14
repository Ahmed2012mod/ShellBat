#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-shell_item_resource
public partial struct SHELL_ITEM_RESOURCE
{
    public Guid guidType;
    public InlineArraySystemChar_260 szName;
}
