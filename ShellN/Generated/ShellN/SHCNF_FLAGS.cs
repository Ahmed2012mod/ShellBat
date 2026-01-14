#nullable enable
namespace ShellN;

[Flags]
public enum SHCNF_FLAGS : uint
{
    SHCNF_IDLIST = 0,
    SHCNF_PATHA = 1,
    SHCNF_PRINTERA = 2,
    SHCNF_DWORD = 3,
    SHCNF_PATHW = 5,
    SHCNF_PRINTERW = 6,
    SHCNF_TYPE = 255,
    SHCNF_FLUSH = 4096,
    SHCNF_FLUSHNOWAIT = 12288,
    SHCNF_NOTIFYRECURSIVE = 65536,
    SHCNF_PATH = 5,
    SHCNF_PRINTER = 6,
}
