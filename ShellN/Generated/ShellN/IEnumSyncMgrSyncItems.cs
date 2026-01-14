#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-ienumsyncmgrsyncitems
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("54b3abf3-f085-4181-b546-e29c403c726b")]
public partial interface IEnumSyncMgrSyncItems
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrsyncitems-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] nint[] rgelt, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrsyncitems-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrsyncitems-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrsyncitems-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSyncMgrSyncItems>))] out IEnumSyncMgrSyncItems ppenum);
}
