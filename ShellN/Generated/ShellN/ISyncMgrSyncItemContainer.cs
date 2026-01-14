#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrsyncitemcontainer
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("90701133-be32-4129-a65c-99e616cafff4")]
public partial interface ISyncMgrSyncItemContainer
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitemcontainer-getsyncitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSyncItem(PWSTR pszItemID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrSyncItem>))] out ISyncMgrSyncItem ppItem);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitemcontainer-getsyncitemenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSyncItemEnumerator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSyncMgrSyncItems>))] out IEnumSyncMgrSyncItems ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitemcontainer-getsyncitemcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSyncItemCount(out uint pcItems);
}
