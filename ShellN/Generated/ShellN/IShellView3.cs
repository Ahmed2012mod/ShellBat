#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ishellview3
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("ec39fa88-f8af-41c5-8421-38bed28f4673")]
public partial interface IShellView3 : IShellView2
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ishellview3-createviewwindow3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateViewWindow3([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellBrowser>))] IShellBrowser psbOwner, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView psvPrev, uint dwViewFlags, FOLDERFLAGS dwMask, FOLDERFLAGS dwFlags, FOLDERVIEWMODE fvMode, in Guid pvid, in RECT prcView, out HWND phwndView);
}
