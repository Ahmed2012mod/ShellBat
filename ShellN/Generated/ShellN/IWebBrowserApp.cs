#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0002df05-0000-0000-c000-000000000046")]
public partial interface IWebBrowserApp : IWebBrowser
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Quit();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClientToWindow(ref int pcx, ref int pcy);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutProperty(BSTR Property, VARIANT vtValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(BSTR Property, out VARIANT pvtValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-iwebbrowserapp-get_hwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HWND(out SHANDLE_PTR pHWND);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FullName(out BSTR FullName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Path(out BSTR Path);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Visible(out VARIANT_BOOL pBool);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Visible(VARIANT_BOOL Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StatusBar(out VARIANT_BOOL pBool);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StatusBar(VARIANT_BOOL Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StatusText(out BSTR StatusText);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_StatusText(BSTR StatusText);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-iwebbrowserapp-get_toolbar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ToolBar(out int Value);
    
    // https://learn.microsoft.com/windows/win32/api/exdisp/nf-exdisp-iwebbrowserapp-put_toolbar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ToolBar(int Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MenuBar(out VARIANT_BOOL Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MenuBar(VARIANT_BOOL Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FullScreen(out VARIANT_BOOL pbFullScreen);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FullScreen(VARIANT_BOOL bFullScreen);
}
