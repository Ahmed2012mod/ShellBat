#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/nn-mobsync-isyncmgrsynchronize
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("6295df40-35ee-11d1-8707-00c04fd93327")]
public partial interface ISyncMgrSynchronize
{
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronize-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(uint dwReserved, uint dwSyncMgrFlags, uint cbCookie, nint /* byte array */ lpCookie);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronize-gethandlerinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHandlerInfo(out nint ppSyncMgrHandlerInfo);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronize-enumsyncmgritems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumSyncMgrItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrEnumItems>))] out ISyncMgrEnumItems ppSyncMgrEnumItems);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronize-getitemobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemObject(in Guid ItemID, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronize-showproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowProperties(HWND hWndParent, in Guid ItemID);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronize-setprogresscallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProgressCallback([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrSynchronizeCallback>))] ISyncMgrSynchronizeCallback lpCallBack);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronize-prepareforsync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrepareForSync(uint cbNumItems, [In][MarshalUsing(CountElementName = nameof(cbNumItems))] Guid[] pItemIDs, HWND hWndParent, uint dwReserved);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronize-synchronize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Synchronize(HWND hWndParent);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronize-setitemstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetItemStatus(in Guid pItemID, uint dwSyncMgrStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronize-showerror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowError(HWND hWndParent, in Guid ErrorID);
}
