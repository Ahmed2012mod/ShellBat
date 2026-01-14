#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_CRYPT_ALLOC(nuint cbSize);
