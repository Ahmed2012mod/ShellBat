#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-extrasearch
public partial struct EXTRASEARCH
{
    public Guid guidSearch;
    public InlineArraySystemChar_80 wszFriendlyName;
    public InlineArrayChar_2084 wszUrl;
}
