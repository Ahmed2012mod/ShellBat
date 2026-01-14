#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/minwinbase/ns-minwinbase-win32_find_dataa
public partial struct WIN32_FIND_DATAA
{
    public uint dwFileAttributes;
    public FILETIME ftCreationTime;
    public FILETIME ftLastAccessTime;
    public FILETIME ftLastWriteTime;
    public uint nFileSizeHigh;
    public uint nFileSizeLow;
    public uint dwReserved0;
    public uint dwReserved1;
    public InlineArrayFoundationCHAR_260 cFileName;
    public InlineArrayCHAR_14 cAlternateFileName;
}
