#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PAPPSTATE_CHANGE_ROUTINE(BOOLEAN Quiesced, nint Context);
