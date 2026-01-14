#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propidlbase/ns-propidlbase-statpropsetstg
public partial struct STATPROPSETSTG
{
    public Guid fmtid;
    public Guid clsid;
    public uint grfFlags;
    public FILETIME mtime;
    public FILETIME ctime;
    public FILETIME atime;
    public uint dwOSVersion;
}
