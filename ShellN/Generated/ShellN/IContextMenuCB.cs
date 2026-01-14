#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icontextmenucb
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("3409e930-5a39-11d1-83fa-00a0c90dc849")]
public partial interface IContextMenuCB
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icontextmenucb-callback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CallBack([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolder?>))] IShellFolder? psf, HWND hwndOwner, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject?>))] IDataObject? pdtobj, uint uMsg, WPARAM wParam, LPARAM lParam);
}
