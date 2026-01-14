#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrconflictresolveinfo
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("c405a219-25a2-442e-8743-b845a2cee93f")]
public partial interface ISyncMgrConflictResolveInfo
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictresolveinfo-getiterationinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIterationInfo(out uint pnCurrentConflict, out uint pcConflicts, out uint pcRemainingForApplyToAll);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictresolveinfo-getpresenternextstep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresenterNextStep(out SYNCMGR_PRESENTER_NEXT_STEP pnPresenterNextStep);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictresolveinfo-getpresenterchoice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresenterChoice(out SYNCMGR_PRESENTER_CHOICE pnPresenterChoice, out BOOL pfApplyToAll);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictresolveinfo-getitemchoicecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemChoiceCount(out uint pcChoices);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictresolveinfo-getitemchoice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemChoice(uint iChoice, out uint piChoiceIndex);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictresolveinfo-setpresenternextstep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP nPresenterNextStep);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictresolveinfo-setpresenterchoice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPresenterChoice(SYNCMGR_PRESENTER_CHOICE nPresenterChoice, BOOL fApplyToAll);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictresolveinfo-setitemchoices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetItemChoices(ref uint prgiConflictItemIndexes, uint cChoices);
}
