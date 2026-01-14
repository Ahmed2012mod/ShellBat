#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-ienumsyncmgrconflict
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("82705914-dda3-4893-ba99-49de6c8c8036")]
public partial interface IEnumSyncMgrConflict
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrconflict-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] nint[] rgelt, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrconflict-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrconflict-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrconflict-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSyncMgrConflict>))] out IEnumSyncMgrConflict ppenum);
}
