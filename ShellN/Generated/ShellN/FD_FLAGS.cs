#nullable enable
namespace ShellN;

public enum FD_FLAGS
{
    FD_CLSID = 1,
    FD_SIZEPOINT = 2,
    FD_ATTRIBUTES = 4,
    FD_CREATETIME = 8,
    FD_ACCESSTIME = 16,
    FD_WRITESTIME = 32,
    FD_FILESIZE = 64,
    FD_PROGRESSUI = 16384,
    FD_LINKUI = 32768,
    FD_UNICODE = int.MinValue,
}
