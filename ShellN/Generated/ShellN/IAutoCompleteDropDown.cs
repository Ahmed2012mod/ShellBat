#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iautocompletedropdown
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3cd141f4-3c6a-11d2-bcaa-00c04fd929db")]
public partial interface IAutoCompleteDropDown
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iautocompletedropdown-getdropdownstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDropDownStatus(out uint pdwFlags, out PWSTR ppwszString);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iautocompletedropdown-resetenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetEnumerator();
}
