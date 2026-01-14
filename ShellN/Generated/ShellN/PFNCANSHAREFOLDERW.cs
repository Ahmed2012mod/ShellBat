#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFNCANSHAREFOLDERW(PWSTR pszPath);
