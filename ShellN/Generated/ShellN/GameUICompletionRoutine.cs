#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void GameUICompletionRoutine(HRESULT returnCode, nint context);
