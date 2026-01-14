#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrconflictresolutionitems
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("458725b9-129d-4135-a998-9ceafec27007")]
public partial interface ISyncMgrConflictResolutionItems
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictresolutionitems-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictresolutionitems-getitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItem(uint iIndex, out CONFIRM_CONFLICT_RESULT_INFO pItemInfo);
}
