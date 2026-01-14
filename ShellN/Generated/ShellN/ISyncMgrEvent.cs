#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgrevent
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fee0ef8b-46bd-4db4-b7e6-ff2c687313bc")]
public partial interface ISyncMgrEvent
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-geteventid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventID(out Guid pguidEventID);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-gethandlerid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHandlerID(out PWSTR ppszHandlerID);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-getitemid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemID(out PWSTR ppszItemID);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-getlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLevel(out SYNCMGR_EVENT_LEVEL pnLevel);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out SYNCMGR_EVENT_FLAGS pnFlags);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-gettime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTime(out FILETIME pfCreationTime);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out PWSTR ppszName);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-getdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription(out PWSTR ppszDescription);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-getlinktext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLinkText(out PWSTR ppszLinkText);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-getlinkreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLinkReference(out PWSTR ppszLinkReference);
    
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgrevent-getcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContext(out PWSTR ppszContext);
}
