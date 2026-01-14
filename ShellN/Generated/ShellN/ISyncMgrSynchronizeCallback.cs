#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/nn-mobsync-isyncmgrsynchronizecallback
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("6295df41-35ee-11d1-8707-00c04fd93327")]
public partial interface ISyncMgrSynchronizeCallback
{
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizecallback-showpropertiescompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowPropertiesCompleted(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizecallback-prepareforsynccompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrepareForSyncCompleted(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizecallback-synchronizecompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SynchronizeCompleted(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizecallback-showerrorcompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowErrorCompleted(HRESULT hr, uint cItems, [In][MarshalUsing(CountElementName = nameof(cItems))] Guid[] pItemIDs);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizecallback-enablemodeless
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableModeless(BOOL fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizecallback-progress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Progress(in Guid ItemID, in SYNCMGRPROGRESSITEM pSyncProgressItem);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizecallback-logerror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LogError(uint dwErrorLevel, PWSTR pszErrorText, in SYNCMGRLOGERRORINFO pSyncLogError);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizecallback-deletelogerror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteLogError(in Guid ErrorID, uint dwReserved);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizecallback-establishconnection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EstablishConnection(PWSTR pwszConnection, uint dwReserved);
}
