#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrsynciteminfo
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e7fd9502-be0c-4464-90a1-2b5277031232")]
public partial interface ISyncMgrSyncItemInfo
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynciteminfo-gettypelabel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeLabel(out PWSTR ppszTypeLabel);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynciteminfo-getcomment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComment(out PWSTR ppszComment);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynciteminfo-getlastsynctime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastSyncTime(out FILETIME pftLastSync);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynciteminfo-isenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEnabled();
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynciteminfo-isconnected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsConnected();
}
