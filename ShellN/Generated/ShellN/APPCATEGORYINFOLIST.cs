#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/appmgmt/ns-appmgmt-appcategoryinfolist
public partial struct APPCATEGORYINFOLIST
{
    public uint cCategory;
    public nint pCategoryInfo;
}
