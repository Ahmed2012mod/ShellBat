#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinputobjectsite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("f1db8392-7331-11d0-8c99-00a0c92dbfe8")]
public partial interface IInputObjectSite
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinputobjectsite-onfocuschangeis
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnFocusChangeIS(nint punkObj, BOOL fSetFocus);
}
