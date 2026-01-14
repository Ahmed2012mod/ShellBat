#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT DLLGETVERSIONPROC(nint param0);
