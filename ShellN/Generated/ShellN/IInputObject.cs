#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinputobject
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("68284faa-6a48-11d0-8c78-00c04fd918b4")]
public partial interface IInputObject
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinputobject-uiactivateio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UIActivateIO(BOOL fActivate, in MSG pMsg);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinputobject-hasfocusio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasFocusIO();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinputobject-translateacceleratorio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAcceleratorIO(in MSG pMsg);
}
