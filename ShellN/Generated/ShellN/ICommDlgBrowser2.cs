#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icommdlgbrowser2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("10339516-2894-11d2-9039-00c04f8eeb3e")]
public partial interface ICommDlgBrowser2 : ICommDlgBrowser
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icommdlgbrowser2-notify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView ppshv, uint dwNotifyType);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icommdlgbrowser2-getdefaultmenutext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultMenuText([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView ppshv, [MarshalUsing(CountElementName = nameof(cchMax))] PWSTR pszText, int cchMax);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icommdlgbrowser2-getviewflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewFlags(out uint pdwFlags);
}
