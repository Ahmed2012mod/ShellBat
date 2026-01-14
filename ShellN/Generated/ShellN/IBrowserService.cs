#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/nn-shdeprecated-ibrowserservice
[GeneratedComInterface, Guid("02ba3b52-0547-11d1-b833-00c04fc9b31f")]
public partial interface IBrowserService
{
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-getparentsite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParentSite([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleInPlaceSite>))] out IOleInPlaceSite ppipsite);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-settitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTitle([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView psv, PWSTR pszName);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-gettitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTitle([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView psv, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR pszName, uint cchName);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-getoleobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOleObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleObject>))] out IOleObject ppobjv);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-gettravellog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTravelLog([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITravelLog>))] out ITravelLog pptl);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-showcontrolwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowControlWindow(uint id, BOOL fShow);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-iscontrolwindowshown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsControlWindowShown(uint id, out BOOL pfShown);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-iegetdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IEGetDisplayName(nint pidl, PWSTR pwszName, uint uFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-ieparsedisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IEParseDisplayName(uint uiCP, PWSTR pwszPath, out nint ppidlOut);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-displayparseerror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayParseError(HRESULT hres, PWSTR pwszPath);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-navigatetopidl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NavigateToPidl(nint pidl, uint grfHLNF);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-setnavigatestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNavigateState(BNSTATE bnstate);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-getnavigatestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNavigateState(out BNSTATE pbnstate);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-notifyredirect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyRedirect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView psv, nint pidl, out BOOL pfDidBrowse);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-updatewindowlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateWindowList();
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-updatebackforwardstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateBackForwardState();
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(uint dwFlags, uint dwFlagMask);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-cannavigatenow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanNavigateNow();
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-getpidl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPidl(out nint ppidl);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-setreferrer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReferrer(nint pidl);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-getbrowserindex
    [PreserveSig]
    uint GetBrowserIndex();
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-getbrowserbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBrowserByIndex(uint dwID, out nint ppunk);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-gethistoryobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHistoryObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleObject>))] out IOleObject ppole, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream pstm, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] out IBindCtx ppbc);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-sethistoryobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHistoryObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleObject>))] IOleObject pole, BOOL fIsLocalAnchor);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-cacheoleserver
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CacheOLEServer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleObject>))] IOleObject pole);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-getsetcodepage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSetCodePage(in VARIANT pvarIn, out VARIANT pvarOut);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-onhttpequiv
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnHttpEquiv([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView psv, BOOL fDone, in VARIANT pvarargIn, out VARIANT pvarargOut);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-getpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPalette(out HPALETTE hpal);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-ibrowserservice-registerwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterWindow(BOOL fForceRegister, ShellWindowTypeConstants swc);
}
