#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrconflict
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("9c204249-c443-4ba4-85ed-c972681db137")]
public partial interface ISyncMgrConflict
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflict-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(in PROPERTYKEY propkey, out PROPVARIANT ppropvar);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflict-getconflictidinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConflictIdInfo(out SYNCMGR_CONFLICT_ID_INFO pConflictIdInfo);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflict-getitemsarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemsArray([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrConflictItems>))] out ISyncMgrConflictItems ppArray);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflict-resolve
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resolve([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrConflictResolveInfo>))] ISyncMgrConflictResolveInfo pResolveInfo);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrconflict-getresolutionhandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResolutionHandler(in Guid riid, out nint /* void */ ppvResolutionHandler);
}
