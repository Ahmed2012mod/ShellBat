#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-inamespacetreecontrol
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("028212a3-b627-47e9-8856-c14265554e4f")]
public partial interface INameSpaceTreeControl
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(HWND hwndParent, in RECT prc, uint nsctsFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-treeadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TreeAdvise(nint punk, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-treeunadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TreeUnadvise(uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-appendroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendRoot([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiRoot, uint grfEnumFlags, uint grfRootStyle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemFilter>))] IShellItemFilter pif);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-insertroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertRoot(int iIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiRoot, uint grfEnumFlags, uint grfRootStyle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemFilter>))] IShellItemFilter pif);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-removeroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveRoot([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiRoot);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-removeallroots
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllRoots();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-getrootitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRootItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] out IShellItemArray ppsiaRootItems);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-setitemstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetItemState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, uint nstcisMask, uint nstcisFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-getitemstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, uint nstcisMask, out uint pnstcisFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-getselecteditems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelectedItems([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] out IShellItemArray psiaItems);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-getitemcustomstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemCustomState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, out int piStateNumber);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-setitemcustomstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetItemCustomState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, int iStateNumber);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-ensureitemvisible
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnsureItemVisible([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-settheme
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTheme(PWSTR pszTheme);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-getnextitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, NSTCGNI nstcgi, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem ppsiNext);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-hittest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HitTest(in POINT ppt, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem ppsiOut);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-getitemrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemRect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, out RECT prect);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacetreecontrol-collapseall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CollapseAll();
}
