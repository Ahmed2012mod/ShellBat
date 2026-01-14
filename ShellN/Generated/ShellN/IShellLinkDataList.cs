#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishelllinkdatalist
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("45e2b4ae-b1c3-11d0-b92f-00a0c90312e1")]
public partial interface IShellLinkDataList
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkdatalist-adddatablock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDataBlock(nint pDataBlock);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkdatalist-copydatablock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyDataBlock(uint dwSig, out nint ppDataBlock);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkdatalist-removedatablock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveDataBlock(uint dwSig);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkdatalist-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelllinkdatalist-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(uint dwFlags);
}
