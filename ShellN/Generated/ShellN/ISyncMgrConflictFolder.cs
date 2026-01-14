#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrconflictfolder
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("59287f5e-bc81-4fca-a7f1-e5a8ecdb1d69")]
public partial interface ISyncMgrConflictFolder
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictfolder-getconflictidlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConflictIDList([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrConflict>))] ISyncMgrConflict pConflict, out nint ppidlConflict);
}
