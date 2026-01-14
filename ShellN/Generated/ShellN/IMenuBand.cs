#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-imenuband
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("568804cd-cbd7-11d0-9816-00c04fd91972")]
public partial interface IMenuBand
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-imenuband-ismenumessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsMenuMessage(in MSG pmsg);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-imenuband-translatemenumessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateMenuMessage(ref MSG pmsg, out LRESULT plRet);
}
