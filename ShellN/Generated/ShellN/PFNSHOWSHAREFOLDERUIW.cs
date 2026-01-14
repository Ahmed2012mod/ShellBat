#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFNSHOWSHAREFOLDERUIW(HWND hwndParent, PWSTR pszPath);
