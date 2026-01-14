#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-istreamasync
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fe0b6665-e0ca-49b9-a178-2b5cb48d92a5")]
public partial interface IStreamAsync : IStream
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-istreamasync-readasync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadAsync(nint pv, uint cb, nint /* optional uint* */ pcbRead, in OVERLAPPED lpOverlapped);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-istreamasync-writeasync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteAsync(nint lpBuffer, uint cb, nint /* optional uint* */ pcbWritten, in OVERLAPPED lpOverlapped);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-istreamasync-overlappedresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OverlappedResult(in OVERLAPPED lpOverlapped, out uint lpNumberOfBytesTransferred, BOOL bWait);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-istreamasync-cancelio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelIo();
}
