#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/ns-searchapi-search_column_properties
public partial struct SEARCH_COLUMN_PROPERTIES
{
    public PROPVARIANT Value;
    public uint lcid;
}
