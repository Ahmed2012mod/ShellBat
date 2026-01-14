#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/exdisp/nn-exdisp-ishellwindows
[GeneratedComInterface, Guid("85cb6900-4d95-11cf-960c-0080c7f4ee85")]
public partial interface IShellWindows : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(VARIANT index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch Folder);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-_newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT _NewEnum(out nint ppunk);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-register
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Register([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch pid, int hwnd, ShellWindowTypeConstants swClass, out int plCookie);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-registerpending
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterPending(int lThreadId, in VARIANT pvarloc, in VARIANT pvarlocRoot, ShellWindowTypeConstants swClass, out int plCookie);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-revoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Revoke(int lCookie);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-onnavigate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnNavigate(int lCookie, in VARIANT pvarLoc);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-onactivated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnActivated(int lCookie, VARIANT_BOOL fActive);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-findwindowsw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindWindowSW(in VARIANT pvarLoc, in VARIANT pvarLocRoot, ShellWindowTypeConstants swClass, out int phwnd, ShellWindowFindWindowOptions swfwOptions, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppdispOut);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-oncreated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnCreated(int lCookie, nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-ishellwindows-processattachdetach
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessAttachDetach(VARIANT_BOOL fAttach);
}
