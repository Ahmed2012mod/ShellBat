#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrsyncitem
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b20b24ce-2593-4f04-bd8b-7ad6c45051cd")]
public partial interface ISyncMgrSyncItem
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitem-getitemid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemID(out PWSTR ppszItemID);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitem-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out PWSTR ppszName);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitem-getiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrSyncItemInfo>))] out ISyncMgrSyncItemInfo ppItemInfo);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitem-getobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObject(in Guid rguidObjectID, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitem-getcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilities(out SYNCMGR_ITEM_CAPABILITIES pmCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitem-getpolicies
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPolicies(out SYNCMGR_ITEM_POLICIES pmPolicies);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitem-enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enable(BOOL fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrsyncitem-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete();
}
