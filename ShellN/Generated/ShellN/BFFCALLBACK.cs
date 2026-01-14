#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int BFFCALLBACK(HWND hwnd, uint uMsg, LPARAM lParam, LPARAM lpData);
