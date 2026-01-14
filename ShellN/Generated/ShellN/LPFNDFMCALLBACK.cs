#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPFNDFMCALLBACK(nint /* IShellFolder */ psf, HWND hwnd, nint /* IDataObject */ pdtobj, uint uMsg, WPARAM wParam, LPARAM lParam);
