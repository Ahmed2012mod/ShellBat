#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrsynccallback
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("884ccd87-b139-4937-a4ba-4f8e19513fbe")]
public partial interface ISyncMgrSyncCallback
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynccallback-reportprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReportProgress(PWSTR pszItemID, PWSTR pszProgressText, SYNCMGR_PROGRESS_STATUS nStatus, uint uCurrentStep, uint uMaxStep, ref SYNCMGR_CANCEL_REQUEST pnCancelRequest);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynccallback-sethandlerprogresstext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHandlerProgressText(PWSTR pszProgressText, ref SYNCMGR_CANCEL_REQUEST pnCancelRequest);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynccallback-reportevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReportEvent(PWSTR pszItemID, SYNCMGR_EVENT_LEVEL nLevel, SYNCMGR_EVENT_FLAGS nFlags, PWSTR pszName, PWSTR pszDescription, PWSTR pszLinkText, PWSTR pszLinkReference, PWSTR pszContext, out Guid pguidEventID);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynccallback-cancontinue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanContinue(PWSTR pszItemID);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynccallback-queryforadditionalitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryForAdditionalItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumString>))] out IEnumString ppenumItemIDs, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumUnknown>))] out IEnumUnknown ppenumPunks);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynccallback-additemtosession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddItemToSession(PWSTR pszItemID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddIUnknownToSession(nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynccallback-proposeitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProposeItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrSyncItem>))] ISyncMgrSyncItem pNewItem);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynccallback-commititem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitItem(PWSTR pszItemID);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsynccallback-reportmanualsync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReportManualSync();
}
