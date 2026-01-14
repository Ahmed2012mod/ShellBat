#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrconflictitems
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("9c7ead52-8023-4936-a4db-d2a9a99e436a")]
public partial interface ISyncMgrConflictItems
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictitems-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflictitems-getitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItem(uint iIndex, out CONFIRM_CONFLICT_ITEM pItemInfo);
}
