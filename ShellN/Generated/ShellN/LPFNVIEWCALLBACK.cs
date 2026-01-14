#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPFNVIEWCALLBACK(nint /* IShellView */ psvOuter, nint /* IShellFolder */ psf, HWND hwndMain, uint uMsg, WPARAM wParam, LPARAM lParam);
