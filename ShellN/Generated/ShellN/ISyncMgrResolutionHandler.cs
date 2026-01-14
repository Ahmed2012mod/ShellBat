#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrresolutionhandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("40a3d052-8bff-4c4b-a338-d4a395700de9")]
public partial interface ISyncMgrResolutionHandler
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrresolutionhandler-queryabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryAbilities(out uint pdwAbilities);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrresolutionhandler-keepother
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KeepOther([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiOther, out SYNCMGR_RESOLUTION_FEEDBACK pFeedback);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrresolutionhandler-keeprecent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KeepRecent(out SYNCMGR_RESOLUTION_FEEDBACK pFeedback);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrresolutionhandler-removefromsyncset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveFromSyncSet(out SYNCMGR_RESOLUTION_FEEDBACK pFeedback);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrresolutionhandler-keepitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KeepItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrConflictResolutionItems>))] ISyncMgrConflictResolutionItems pArray, out SYNCMGR_RESOLUTION_FEEDBACK pFeedback);
}
