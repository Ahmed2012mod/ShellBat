#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellview2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("88e39e80-3578-11cf-ae69-08002b2e1262")]
public partial interface IShellView2 : IShellView
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview2-getview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetView(ref Guid pvid, uint uView);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview2-createviewwindow2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateViewWindow2(in SV2CVW2_PARAMS lpParams);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview2-handlerename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HandleRename(nint pidlNew);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellview2-selectandpositionitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectAndPositionItem(nint pidlItem, uint uFlags, in POINT ppt);
}
