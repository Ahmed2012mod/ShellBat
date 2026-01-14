#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/exdisp/nn-exdisp-iwebbrowser2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("d30c1661-cdaf-11d0-8a3e-00c04fc9e26e")]
public partial interface IWebBrowser2 : IWebBrowserApp
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Navigate2(in VARIANT URL, nint /* optional VARIANT* */ Flags, nint /* optional VARIANT* */ TargetFrameName, nint /* optional VARIANT* */ PostData, nint /* optional VARIANT* */ Headers);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryStatusWB(OLECMDID cmdID, out OLECMDF pcmdf);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExecWB(OLECMDID cmdID, OLECMDEXECOPT cmdexecopt, nint /* optional VARIANT* */ pvaIn, nint /* optional VARIANT* */ pvaOut);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowBrowserBar(in VARIANT pvaClsid, nint /* optional VARIANT* */ pvarShow, nint /* optional VARIANT* */ pvarSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ReadyState(out READYSTATE plReadyState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Offline(out VARIANT_BOOL pbOffline);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Offline(VARIANT_BOOL bOffline);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Silent(out VARIANT_BOOL pbSilent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Silent(VARIANT_BOOL bSilent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RegisterAsBrowser(out VARIANT_BOOL pbRegister);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RegisterAsBrowser(VARIANT_BOOL bRegister);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RegisterAsDropTarget(out VARIANT_BOOL pbRegister);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RegisterAsDropTarget(VARIANT_BOOL bRegister);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-iwebbrowser2-get_theatermode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TheaterMode(out VARIANT_BOOL pbRegister);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-iwebbrowser2-put_theatermode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TheaterMode(VARIANT_BOOL bRegister);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AddressBar(out VARIANT_BOOL Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AddressBar(VARIANT_BOOL Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Resizable(out VARIANT_BOOL Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Resizable(VARIANT_BOOL Value);
}
