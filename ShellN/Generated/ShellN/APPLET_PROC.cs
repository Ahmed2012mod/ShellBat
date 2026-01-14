#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int APPLET_PROC(HWND hwndCpl, uint msg, LPARAM lParam1, LPARAM lParam2);
