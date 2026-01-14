#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PAPPCONSTRAIN_CHANGE_ROUTINE(BOOLEAN Constrained, nint Context);
