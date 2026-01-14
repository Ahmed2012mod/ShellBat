#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icommdlgbrowser
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214f1-0000-0000-c000-000000000046")]
public partial interface ICommDlgBrowser
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icommdlgbrowser-ondefaultcommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDefaultCommand([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView ppshv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icommdlgbrowser-onstatechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStateChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView ppshv, uint uChange);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icommdlgbrowser-includeobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IncludeObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView ppshv, nint pidl);
}
