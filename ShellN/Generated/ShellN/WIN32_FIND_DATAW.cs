#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/minwinbase/ns-minwinbase-win32_find_dataw
public partial struct WIN32_FIND_DATAW
{
    public uint dwFileAttributes;
    public FILETIME ftCreationTime;
    public FILETIME ftLastAccessTime;
    public FILETIME ftLastWriteTime;
    public uint nFileSizeHigh;
    public uint nFileSizeLow;
    public uint dwReserved0;
    public uint dwReserved1;
    public InlineArraySystemChar_260 cFileName;
    public InlineArrayChar_14 cAlternateFileName;
}
