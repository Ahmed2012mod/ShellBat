#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrconflictpresenter
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("0b4f5353-fd2b-42cd-8763-4779f2d508a3")]
public partial interface ISyncMgrConflictPresenter
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictpresenter-presentconflict
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PresentConflict([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrConflict>))] ISyncMgrConflict pConflict, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrConflictResolveInfo>))] ISyncMgrConflictResolveInfo pResolveInfo);
}
