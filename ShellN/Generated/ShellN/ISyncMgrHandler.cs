#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrhandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("04ec2e43-ac77-49f9-9b98-0307ef7a72a2")]
public partial interface ISyncMgrHandler
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandler-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out PWSTR ppszName);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandler-gethandlerinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHandlerInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrHandlerInfo>))] out ISyncMgrHandlerInfo ppHandlerInfo);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandler-getobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObject(in Guid rguidObjectID, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandler-getcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilities(out SYNCMGR_HANDLER_CAPABILITIES pmCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandler-getpolicies
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPolicies(out SYNCMGR_HANDLER_POLICIES pmPolicies);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandler-activate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Activate(BOOL fActivate);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandler-enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enable(BOOL fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrhandler-synchronize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Synchronize([In][MarshalUsing(CountElementName = nameof(cItems))] PWSTR[] ppszItemIDs, uint cItems, HWND hwndOwner, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrSessionCreator>))] ISyncMgrSessionCreator pSessionCreator, nint punk);
}
