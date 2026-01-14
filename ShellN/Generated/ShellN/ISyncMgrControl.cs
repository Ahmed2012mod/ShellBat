#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrcontrol
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("9b63616c-36b2-46bc-959f-c1593952d19b")]
public partial interface ISyncMgrControl
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-starthandlersync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartHandlerSync(PWSTR pszHandlerID, HWND hwndOwner, nint punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrSyncResult>))] ISyncMgrSyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-startitemsync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartItemSync(PWSTR pszHandlerID, [In][MarshalUsing(CountElementName = nameof(cItems))] PWSTR[] ppszItemIDs, uint cItems, HWND hwndOwner, nint punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrSyncResult>))] ISyncMgrSyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-startsyncall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartSyncAll(HWND hwndOwner);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-stophandlersync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopHandlerSync(PWSTR pszHandlerID);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-stopitemsync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopItemSync(PWSTR pszHandlerID, [In][MarshalUsing(CountElementName = nameof(cItems))] PWSTR[] ppszItemIDs, uint cItems);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-stopsyncall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopSyncAll();
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-updatehandlercollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateHandlerCollection(in Guid rclsidCollectionID, SYNCMGR_CONTROL_FLAGS nControlFlags);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-updatehandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateHandler(PWSTR pszHandlerID, SYNCMGR_CONTROL_FLAGS nControlFlags);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-updateitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateItem(PWSTR pszHandlerID, PWSTR pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-updateevents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateEvents(PWSTR pszHandlerID, PWSTR pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateConflict(PWSTR pszHandlerID, PWSTR pszItemID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrConflict>))] ISyncMgrConflict pConflict, SYNCMGR_UPDATE_REASON nReason);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-updateconflicts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateConflicts(PWSTR pszHandlerID, PWSTR pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-activatehandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateHandler(BOOL fActivate, PWSTR pszHandlerID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-enablehandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableHandler(BOOL fEnable, PWSTR pszHandlerID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrcontrol-enableitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableItem(BOOL fEnable, PWSTR pszHandlerID, PWSTR pszItemID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags);
}
