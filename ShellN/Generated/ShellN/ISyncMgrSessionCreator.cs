#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrsessioncreator
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("17f48517-f305-4321-a08d-b25a834918fd")]
public partial interface ISyncMgrSessionCreator
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsessioncreator-createsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSession(PWSTR pszHandlerID, [In][MarshalUsing(CountElementName = nameof(cItems))] PWSTR[] ppszItemIDs, uint cItems, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrSyncCallback>))] out ISyncMgrSyncCallback ppCallback);
}
