#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-imenupopup
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("d1e7afeb-6a2e-11d0-8c78-00c04fd918b4")]
public partial interface IMenuPopup : IDeskBar
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-imenupopup-popup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Popup(in POINTL ppt, nint /* optional RECTL* */ prcExclude, int dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-imenupopup-onselect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSelect(uint dwSelectType);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-imenupopup-setsubmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSubMenu([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMenuPopup>))] IMenuPopup pmp, BOOL fSet);
}
