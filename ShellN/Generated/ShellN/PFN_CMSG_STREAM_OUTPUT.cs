#nullable enable
namespace ShellN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_CMSG_STREAM_OUTPUT(nint /* optional void* */ pvArg, nint /* optional byte* */ pbData, uint cbData, BOOL fFinal);
