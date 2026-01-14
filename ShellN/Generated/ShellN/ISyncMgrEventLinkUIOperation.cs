#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgreventlinkuioperation
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("64522e52-848b-4015-89ce-5a36f00b94ff")]
public partial interface ISyncMgrEventLinkUIOperation : ISyncMgrUIOperation
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgreventlinkuioperation-init
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Init(in Guid rguidEventID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrEvent>))] ISyncMgrEvent pEvent);
}
