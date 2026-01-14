#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrhandlerinfo
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("4ff1d798-ecf7-4524-aa81-1e362a0aef3a")]
public partial interface ISyncMgrHandlerInfo
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandlerinfo-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out SYNCMGR_HANDLER_TYPE pnType);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandlerinfo-gettypelabel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeLabel(out PWSTR ppszTypeLabel);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandlerinfo-getcomment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComment(out PWSTR ppszComment);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandlerinfo-getlastsynctime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastSyncTime(out FILETIME pftLastSync);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandlerinfo-isactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsActive();
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandlerinfo-isenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEnabled();
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandlerinfo-isconnected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsConnected();
}
