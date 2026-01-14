#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PlayerPickerUICompletionRoutine(HRESULT returnCode, nint context, nint /* in HSTRING */ selectedXuids, nuint selectedXuidsCount);
