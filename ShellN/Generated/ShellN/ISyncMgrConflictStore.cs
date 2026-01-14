#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrconflictstore
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("cf8fc579-c396-4774-85f1-d908a831156e")]
public partial interface ISyncMgrConflictStore
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictstore-enumconflicts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumConflicts(PWSTR pszHandlerID, PWSTR pszItemID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSyncMgrConflict>))] out IEnumSyncMgrConflict ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictstore-bindtoconflict
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToConflict(in SYNCMGR_CONFLICT_ID_INFO pConflictIdInfo, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictstore-removeconflicts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveConflicts([In][MarshalUsing(CountElementName = nameof(cConflicts))] SYNCMGR_CONFLICT_ID_INFO[] rgConflictIdInfo, uint cConflicts);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictstore-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(PWSTR pszHandlerID, PWSTR pszItemID, out uint pnConflicts);
}
