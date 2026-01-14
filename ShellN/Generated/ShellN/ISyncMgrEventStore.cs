#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgreventstore
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("37e412f9-016e-44c2-81ff-db3add774266")]
public partial interface ISyncMgrEventStore
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgreventstore-geteventenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventEnumerator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSyncMgrEvents>))] out IEnumSyncMgrEvents ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgreventstore-geteventcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventCount(out uint pcEvents);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgreventstore-getevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEvent(in Guid rguidEventID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrEvent>))] out ISyncMgrEvent ppEvent);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgreventstore-removeevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveEvent([In][MarshalUsing(CountElementName = nameof(cEvents))] Guid[] pguidEventIDs, uint cEvents);
}
