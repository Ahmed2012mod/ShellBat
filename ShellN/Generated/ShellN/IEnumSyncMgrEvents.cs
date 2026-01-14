#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-ienumsyncmgrevents
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("c81a1d4e-8cf7-4683-80e0-bcae88d677b6")]
public partial interface IEnumSyncMgrEvents
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrevents-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] nint[] rgelt, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrevents-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrevents-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-ienumsyncmgrevents-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSyncMgrEvents>))] out IEnumSyncMgrEvents ppenum);
}
