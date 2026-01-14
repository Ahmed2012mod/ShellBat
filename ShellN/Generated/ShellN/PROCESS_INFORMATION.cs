#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/processthreadsapi/ns-processthreadsapi-process_information
public partial struct PROCESS_INFORMATION
{
    public HANDLE hProcess;
    public HANDLE hThread;
    public uint dwProcessId;
    public uint dwThreadId;
}
